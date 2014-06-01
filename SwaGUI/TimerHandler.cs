using System;
using System.Drawing;
using System.Timers;

namespace SwagGUI
{
    internal class TimerHandler
    {
        public static Timer timer;

        public static void InitTimer()
        {
            if (timer == null)
            {
                timer = new Timer(500);
                timer.Elapsed += new ElapsedEventHandler(timerTask);
            }
        }

        public static void StartTimer()
        {
            InitTimer();
            timer.Enabled = true;
        }

        public static void StopTimer()
        {
            InitTimer();
            timer.Enabled = false;
        }

        public static bool TimerEnabled()
        {
            InitTimer();
            return timer.Enabled;
        }

        private static void timerTask(Object source, ElapsedEventArgs e)
        {
            int tick = Environment.TickCount;
            Bitmap bitmap = ScreenCapturer.CaptureHealthArea();
            if (bitmap != null)
            {
                int hp = NumberParser.ParseNumber(bitmap);
            }
            Console.WriteLine("Took " + (Environment.TickCount - tick) + "ms.");
        }
    }
}