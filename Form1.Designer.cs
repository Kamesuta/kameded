namespace kameded
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kameded = new System.Windows.Forms.PictureBox();
            this.panel_time = new System.Windows.Forms.Panel();
            this.panel_front = new System.Windows.Forms.Panel();
            this.group_pkt = new System.Windows.Forms.GroupBox();
            this.pkt_time = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.group_elapsed = new System.Windows.Forms.GroupBox();
            this.elapsed_time = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ded_date = new System.Windows.Forms.Label();
            this.elapsed_timer = new System.Windows.Forms.Timer(this.components);
            this.panel_back = new System.Windows.Forms.Panel();
            this.kamewait = new System.Windows.Forms.Panel();
            this.kamewait_time = new System.Windows.Forms.Label();
            this.kameblank = new System.Windows.Forms.PictureBox();
            this.kamepkt = new System.Windows.Forms.PictureBox();
            this.pkt_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kameded)).BeginInit();
            this.panel_time.SuspendLayout();
            this.panel_front.SuspendLayout();
            this.group_pkt.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.group_elapsed.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_back.SuspendLayout();
            this.kamewait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kameblank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamepkt)).BeginInit();
            this.SuspendLayout();
            // 
            // kameded
            // 
            this.kameded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kameded.Image = global::kameded.Properties.Resources.kameded;
            this.kameded.InitialImage = null;
            this.kameded.Location = new System.Drawing.Point(0, 0);
            this.kameded.Name = "kameded";
            this.kameded.Size = new System.Drawing.Size(255, 253);
            this.kameded.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kameded.TabIndex = 0;
            this.kameded.TabStop = false;
            // 
            // panel_time
            // 
            this.panel_time.BackColor = System.Drawing.SystemColors.Window;
            this.panel_time.Controls.Add(this.panel_front);
            this.panel_time.Controls.Add(this.group_elapsed);
            this.panel_time.Controls.Add(this.groupBox1);
            this.panel_time.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_time.Location = new System.Drawing.Point(0, 253);
            this.panel_time.Name = "panel_time";
            this.panel_time.Size = new System.Drawing.Size(255, 70);
            this.panel_time.TabIndex = 1;
            // 
            // panel_front
            // 
            this.panel_front.BackColor = System.Drawing.SystemColors.Window;
            this.panel_front.Controls.Add(this.group_pkt);
            this.panel_front.Controls.Add(this.groupBox3);
            this.panel_front.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_front.Location = new System.Drawing.Point(0, 0);
            this.panel_front.Name = "panel_front";
            this.panel_front.Size = new System.Drawing.Size(255, 70);
            this.panel_front.TabIndex = 6;
            this.panel_front.Visible = false;
            // 
            // group_pkt
            // 
            this.group_pkt.Controls.Add(this.pkt_time);
            this.group_pkt.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.group_pkt.Location = new System.Drawing.Point(131, 6);
            this.group_pkt.Name = "group_pkt";
            this.group_pkt.Size = new System.Drawing.Size(118, 58);
            this.group_pkt.TabIndex = 6;
            this.group_pkt.TabStop = false;
            this.group_pkt.Text = "pkt時";
            // 
            // pkt_time
            // 
            this.pkt_time.AutoSize = true;
            this.pkt_time.BackColor = System.Drawing.Color.Transparent;
            this.pkt_time.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pkt_time.Location = new System.Drawing.Point(2, 24);
            this.pkt_time.Name = "pkt_time";
            this.pkt_time.Size = new System.Drawing.Size(86, 21);
            this.pkt_time.TabIndex = 2;
            this.pkt_time.Text = "--/-- --:--:--";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox3.Location = new System.Drawing.Point(7, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 58);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Discordに記録";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(3, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "kamededをクリックして\r\nDiscordに記録";
            // 
            // group_elapsed
            // 
            this.group_elapsed.Controls.Add(this.elapsed_time);
            this.group_elapsed.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.group_elapsed.Location = new System.Drawing.Point(131, 6);
            this.group_elapsed.Name = "group_elapsed";
            this.group_elapsed.Size = new System.Drawing.Size(118, 58);
            this.group_elapsed.TabIndex = 5;
            this.group_elapsed.TabStop = false;
            this.group_elapsed.Text = "経過時間";
            // 
            // elapsed_time
            // 
            this.elapsed_time.AutoSize = true;
            this.elapsed_time.BackColor = System.Drawing.Color.Transparent;
            this.elapsed_time.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.elapsed_time.Location = new System.Drawing.Point(16, 24);
            this.elapsed_time.Name = "elapsed_time";
            this.elapsed_time.Size = new System.Drawing.Size(82, 21);
            this.elapsed_time.TabIndex = 3;
            this.elapsed_time.Text = "0.00:00:00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ded_date);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 58);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ded時";
            // 
            // ded_date
            // 
            this.ded_date.AutoSize = true;
            this.ded_date.BackColor = System.Drawing.Color.Transparent;
            this.ded_date.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ded_date.Location = new System.Drawing.Point(2, 24);
            this.ded_date.Name = "ded_date";
            this.ded_date.Size = new System.Drawing.Size(116, 21);
            this.ded_date.TabIndex = 1;
            this.ded_date.Text = "10/14 16:59:22";
            // 
            // elapsed_timer
            // 
            this.elapsed_timer.Enabled = true;
            this.elapsed_timer.Interval = 1000;
            this.elapsed_timer.Tick += new System.EventHandler(this.elapsed_timer_Tick);
            // 
            // panel_back
            // 
            this.panel_back.Controls.Add(this.kamewait);
            this.panel_back.Controls.Add(this.kamepkt);
            this.panel_back.Controls.Add(this.kameded);
            this.panel_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_back.Location = new System.Drawing.Point(0, 0);
            this.panel_back.Name = "panel_back";
            this.panel_back.Size = new System.Drawing.Size(255, 253);
            this.panel_back.TabIndex = 2;
            // 
            // kamewait
            // 
            this.kamewait.Controls.Add(this.kamewait_time);
            this.kamewait.Controls.Add(this.kameblank);
            this.kamewait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kamewait.Location = new System.Drawing.Point(0, 0);
            this.kamewait.Name = "kamewait";
            this.kamewait.Size = new System.Drawing.Size(255, 253);
            this.kamewait.TabIndex = 3;
            // 
            // kamewait_time
            // 
            this.kamewait_time.AutoSize = true;
            this.kamewait_time.BackColor = System.Drawing.Color.White;
            this.kamewait_time.Font = new System.Drawing.Font("Yu Gothic UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.kamewait_time.Location = new System.Drawing.Point(83, 55);
            this.kamewait_time.Name = "kamewait_time";
            this.kamewait_time.Size = new System.Drawing.Size(107, 128);
            this.kamewait_time.TabIndex = 3;
            this.kamewait_time.Text = "5";
            this.kamewait_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kameblank
            // 
            this.kameblank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kameblank.Image = global::kameded.Properties.Resources.kameblank;
            this.kameblank.InitialImage = null;
            this.kameblank.Location = new System.Drawing.Point(0, 0);
            this.kameblank.Name = "kameblank";
            this.kameblank.Size = new System.Drawing.Size(255, 253);
            this.kameblank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kameblank.TabIndex = 2;
            this.kameblank.TabStop = false;
            // 
            // kamepkt
            // 
            this.kamepkt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kamepkt.Image = global::kameded.Properties.Resources.kamepkt;
            this.kamepkt.InitialImage = null;
            this.kamepkt.Location = new System.Drawing.Point(0, 0);
            this.kamepkt.Name = "kamepkt";
            this.kamepkt.Size = new System.Drawing.Size(255, 253);
            this.kamepkt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kamepkt.TabIndex = 1;
            this.kamepkt.TabStop = false;
            this.kamepkt.Visible = false;
            this.kamepkt.Click += new System.EventHandler(this.kamepkt_Click);
            this.kamepkt.MouseLeave += new System.EventHandler(this.kamepkt_MouseLeave);
            this.kamepkt.MouseHover += new System.EventHandler(this.kamepkt_MouseHover);
            // 
            // pkt_timer
            // 
            this.pkt_timer.Interval = 1000;
            this.pkt_timer.Tick += new System.EventHandler(this.pkt_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 323);
            this.Controls.Add(this.panel_back);
            this.Controls.Add(this.panel_time);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "kameded";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.kameded)).EndInit();
            this.panel_time.ResumeLayout(false);
            this.panel_front.ResumeLayout(false);
            this.group_pkt.ResumeLayout(false);
            this.group_pkt.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.group_elapsed.ResumeLayout(false);
            this.group_elapsed.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_back.ResumeLayout(false);
            this.kamewait.ResumeLayout(false);
            this.kamewait.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kameblank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamepkt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox kameded;
        private System.Windows.Forms.Panel panel_time;
        private System.Windows.Forms.Label elapsed_time;
        private System.Windows.Forms.Label ded_date;
        private System.Windows.Forms.Timer elapsed_timer;
        private System.Windows.Forms.GroupBox group_elapsed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_back;
        private System.Windows.Forms.GroupBox group_pkt;
        private System.Windows.Forms.Label pkt_time;
        private System.Windows.Forms.Panel panel_front;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox kamepkt;
        private System.Windows.Forms.PictureBox kameblank;
        private System.Windows.Forms.Panel kamewait;
        private System.Windows.Forms.Label kamewait_time;
        private System.Windows.Forms.Timer pkt_timer;
    }
}

