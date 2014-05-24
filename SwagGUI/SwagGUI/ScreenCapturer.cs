using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Threading;

namespace SwagGUI
{
    class ScreenCapturer
    {
        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hWnd);
        private const int SW_RESTORE = 9;
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT rect);

        private static RECT nullRect = new Rectangle(0, 0, 0, 0);

        public static Bitmap CaptureScreen()
        {
            return CaptureScreen(true, nullRect);
        }

        public static Bitmap CaptureHealthArea()
        {
            return CaptureScreen(true, Options.healthBox);
        }

        public static Bitmap CaptureScreen(bool force, RECT area)
        {
            Bitmap bmp = null;
            int now = Environment.TickCount;
            Process[] processes = Process.GetProcessesByName("gw2");
            if (processes.Length > 0)
            {
                Process process = processes[0];
                IntPtr hwnd = process.MainWindowHandle;
                String name = process.MainWindowTitle;
                Console.WriteLine("Found hwnd of " + name + ": " + hwnd);
                bmp = CaptureScreen(hwnd, force, area);
            }
            else
            {
                Console.WriteLine("Could not find hwnd of Guild Wars 2.");
            }
            Console.WriteLine("Capture took " + (Environment.TickCount - now) + "ms.");
            return bmp;
        }

        private static Bitmap CaptureScreen(IntPtr hwnd, bool force, RECT area)
        {
            if (force)
            {
                SetForegroundWindow(hwnd);
                ShowWindow(hwnd, SW_RESTORE);
                Thread.Sleep(10);
            }

            RECT rect = new RECT();
            bool success = GetWindowRect(hwnd, out rect);

            if (success)
            {
                if (area.Width > 0 && area.Height > 0)
                {
                    rect = new Rectangle(rect.Left + area.Left, rect.Top + area.Top, area.Width, area.Height);
                }
                int width = rect.Width;
                int height = rect.Height;

                Bitmap bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
                Graphics.FromImage(bmp).CopyFromScreen(rect.Left, rect.Top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);

                return bmp;
            }
            else
            {
                return null;
            }
        }
    }
}
