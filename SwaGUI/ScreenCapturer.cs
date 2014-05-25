using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading;

namespace SwagGUI
{
    internal class ScreenCapturer
    {
        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hWnd);
        private const int SW_RESTORE = 9;
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
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
            return CaptureScreen(false, Options.healthBox);
        }

        public static Bitmap CaptureScreen(bool force, RECT area)
        {
            Process[] processes = Process.GetProcessesByName("gw2");
            if (processes.Length > 0)
            {
                Process process = processes[0];
                IntPtr hwnd = process.MainWindowHandle;
                String name = process.MainWindowTitle;
                return CaptureScreen(hwnd, force, area);
            }
            Console.Error.WriteLine("Could not find hwnd of Guild Wars 2.");
            return null;
        }

        private static Bitmap CaptureScreen(IntPtr hwnd, bool force, RECT area)
        {
            if (force)
            {
                SetForegroundWindow(hwnd);
                ShowWindow(hwnd, SW_RESTORE);
                Thread.Sleep(10);
            }
            else
            {
                if (GetForegroundWindow() != hwnd)
                {
                    return null;
                }
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

                Bitmap bmp = new Bitmap(width, height, PixelFormat.Format24bppRgb);
                Graphics.FromImage(bmp).CopyFromScreen(rect.Left, rect.Top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
                
                bmp.Save("test.bmp", ImageFormat.Bmp);
                return bmp;
            }
            return null;
        }
    }
}