using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace kameded
{
    class MonitorUtils
    {
        // the message is sent to all 
        // top-level windows in the system
        public const int HWND_BROADCAST = 0xffff;

        // the message is sent to one 
        // top-level window in the system
        public const int HWND_TOPMOST = -1;

        public const int HWND_TOP = 0;           //
        public const int HWND_BOTTOM = 1;        //limited use
        public const int HWND_NOTOPMOST = -2;    //

        public const int SC_MONITORPOWER = 0xF170;
        public const int WM_SYSCOMMAND = 0x0112;

        public const int MONITOR_ON = -1;
        public const int MONITOR_OFF = 2;
        public const int MONITOR_STANBY = 1;

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg,
            IntPtr wParam, IntPtr lParam);

        [DllImport(@"User32", SetLastError = true,
            EntryPoint = "RegisterPowerSettingNotification",
            CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr RegisterPowerSettingNotification(
            IntPtr hRecipient,
            ref Guid PowerSettingGuid,
            Int32 Flags);

        [DllImport(@"User32", SetLastError = true,
            EntryPoint = "UnregisterPowerSettingNotification",
            CallingConvention = CallingConvention.StdCall)]
        private static extern bool UnregisterPowerSettingNotification(
            IntPtr hPower);

        public static Guid GUID_LIDCLOSE_ACTION = new Guid(0xBA3E0F4D, 0xB817, 0x4094, 0xA2, 0xD1, 0xD5, 0x63, 0x79, 0xE6, 0xA0, 0xF3);
        public static Guid GUID_SESSION_DISPLAY_STATUS = new Guid(0x2b84c20e, 0xad23, 0x4ddf, 0x93, 0xdb, 0x05, 0xff, 0xbd, 0x7e, 0xfc, 0xa5);

        public const int WM_POWERBROADCAST = 0x0218;
        public const int DEVICE_NOTIFY_WINDOW_HANDLE = 0x00000000;
        public const int PBT_POWERSETTINGCHANGE = 0x8013; // DPPE

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct POWERBROADCAST_SETTING
        {
            public Guid PowerSetting;
            public uint DataLength;
            public byte Data;
        }

        public static IntPtr RegisterNotification(IntPtr HWND)
        {
            return RegisterPowerSettingNotification(HWND, ref GUID_SESSION_DISPLAY_STATUS, 0);
        }

        public static bool UnregisterNotification(IntPtr hPower)
        {
            return UnregisterPowerSettingNotification(hPower);
        }

        public static void SleepMode(IntPtr HWND)
        {
            SendMessage(HWND, WM_SYSCOMMAND, (IntPtr)SC_MONITORPOWER, (IntPtr)MONITOR_OFF);
        }
    }
}
