using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace kameded
{
    public partial class Form1 : Form
    {
        private readonly IntPtr _powerNotify;

        private readonly DateTime _startTime;
        private DateTime _endTime;

        private bool _monitorOn = true;
        private int _countdown = 5;
        private bool _monitorOff;

        private int _pysmCountdown = 25;
        private string _webhook;

        public Form1(string webhook)
        {
            InitializeComponent();

            _webhook = webhook;

            _startTime = DateTime.Now;
            ded_date.Text = _startTime.ToString("M/d HH:mm:ss");

            _powerNotify = MonitorUtils.RegisterNotification(Handle);

        }

        protected override void OnClosed(EventArgs e)
        {
            MonitorUtils.UnregisterNotification(_powerNotify);

            base.OnClosed(e);
        }

        public void PysmAgain()
        {
            BringToFront();
            Activate();

            _countdown = 8;
            kamewait.Visible = true;
            kamewait_time.Text = _countdown.ToString("D");

            _monitorOff = false;
            elapsed_timer.Enabled = true;
            pkt_time.Text = "--/-- --:--:--";
            kamepkt.Visible = false;
        }

        private void pkt_timer_Tick(object sender, EventArgs e)
        {
            if (_pysmCountdown > 0)
            {
                _pysmCountdown--;
                Text = "kameded - " + _pysmCountdown.ToString("D") + "s";
            }
            else
            {
                pkt_timer.Stop();
                Text = "kameded";
                PysmAgain();
            }

        }

        private void elapsed_timer_Tick(object sender, EventArgs e)
        {
            if (_countdown > 0)
            {
                _countdown--;
                kamewait_time.Text = _countdown.ToString("D");
            }
            else
            {
                if (!_monitorOff)
                {
                    _monitorOn = true;
                    kamewait.Visible = false;
                    MonitorUtils.SleepMode(Handle);
                }
                _monitorOff = true;

                _endTime = DateTime.Now;
                var sub = _endTime - _startTime;
                elapsed_time.Text = sub.ToString("d'.'hh':'mm':'ss");
            }

        }

        private void kamepkt_MouseHover(object sender, EventArgs e)
        {
            panel_front.Visible = true;
        }

        private void kamepkt_MouseLeave(object sender, EventArgs e)
        {
            panel_front.Visible = false;
        }

        public void Pkt()
        {
            elapsed_timer.Stop();
            _endTime = DateTime.Now;
            var sub = _endTime - _startTime;
            elapsed_time.Text = sub.ToString("d'.'hh':'mm':'ss");
            pkt_time.Text = _endTime.ToString("M/d HH:mm:ss");
            kamepkt.Visible = true;

            _pysmCountdown = 25;
            pkt_timer.Stop();
            pkt_timer.Start();
        }

        public void UploadAndExit()
        {
            var sub = _endTime - _startTime;
            var substr = sub.Days > 0 ? sub.ToString("d'日'h'時間'm'分's'秒'") : sub.ToString("h'時間'm'分's'秒'");
            var datestr = _startTime.ToString("yyyy'年'M'月'd'日'(ddd) H'時'm'分's'秒'") + " → " + _endTime.ToString("yyyy'年'M'月'd'日'(ddd) H'時'm'分's'秒'");
            string str = $"🕒 PYSM時間 {substr}```{datestr}```";

            using (DWebHook dcWeb = new DWebHook())
            {
                dcWeb.WebHook = _webhook;
                dcWeb.SendMessage(str);
            }
            Close();
        }

        private void kamepkt_Click(object sender, EventArgs e)
        {
            UploadAndExit();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case MonitorUtils.WM_POWERBROADCAST:
                    if (m.WParam.ToInt32() == MonitorUtils.PBT_POWERSETTINGCHANGE)
                    {
                        //Extract Data From Msg
                        MonitorUtils.POWERBROADCAST_SETTING pSetting =
                            (MonitorUtils.POWERBROADCAST_SETTING)Marshal.PtrToStructure(
                                m.LParam, typeof(MonitorUtils.POWERBROADCAST_SETTING));

                        if (pSetting.PowerSetting == MonitorUtils.GUID_SESSION_DISPLAY_STATUS)
                        {
                            var prev = _monitorOn;
                            switch (pSetting.Data)
                            {
                                case 0: /* monitor is off */
                                    _monitorOn = false;
                                    break;
                                case 1: /* monitor is on */
                                    _monitorOn = true;
                                    break;
                            }

                            // OFF -> ON
                            if (!prev && _monitorOn)
                            {
                                Pkt();
                            }
                        }
                    }
                    break;
            }

            base.WndProc(ref m);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Location = Screen.PrimaryScreen.WorkingArea.Location + new Size(20, 20);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (kamepkt.Visible)
                    UploadAndExit();
                else
                    Close();
            }

        }
    }
}