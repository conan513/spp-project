using System;
using System.Runtime.InteropServices;

namespace BugReportGUI.Class
{
    class Flash
    {
        public static class FlashWindow
        {
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool FlashWindowEx(ref FLASHWINFO pwfi);
            [StructLayout(LayoutKind.Sequential)]
            private struct FLASHWINFO
            {
                public uint cbSize;
                public IntPtr hwnd;
                public uint dwFlags;
                public uint uCount;
                public uint dwTimeout;
            }

            public const uint FLASHW_STOP = 0;
            public const uint FLASHW_ALL = 3;

            private static FLASHWINFO Create_FLASHWINFO(IntPtr handle, uint flags, uint count, uint timeout)
            {
                FLASHWINFO fi = new FLASHWINFO();
                fi.cbSize = Convert.ToUInt32(Marshal.SizeOf(fi));
                fi.hwnd = handle;
                fi.dwFlags = flags;
                fi.uCount = count;
                fi.dwTimeout = timeout;
                return fi;
            }

            public static bool Start(System.Windows.Forms.Form form)
            {
                if (Win2000OrLater)
                {
                    FLASHWINFO fi = Create_FLASHWINFO(form.Handle, FLASHW_ALL, uint.MaxValue, 0);
                    return FlashWindowEx(ref fi);
                }
                return false;
            }
            public static bool Stop(System.Windows.Forms.Form form)
            {
                if (Win2000OrLater)
                {
                    FLASHWINFO fi = Create_FLASHWINFO(form.Handle, FLASHW_STOP, uint.MaxValue, 0);
                    return FlashWindowEx(ref fi);
                }
                return false;
            }
            private static bool Win2000OrLater
            {
                get { return Environment.OSVersion.Version.Major >= 5; }
            }
        }
    }
}
