using System.Windows.Forms;
using System.Threading;
using System;
using System.Drawing;

namespace SwagMap
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private RECT rect = new RECT(1590, 780, 1920, 1080);
        private Thread drawThread;
        private int last = 0;

        private void mainScreen_Load(object sender, EventArgs e)
        {
            StartDrawThread();
        }

        private void buttonCalibrate_Click(object sender, EventArgs e)
        {
            StopDrawThread();
            OptionsWindow window = new OptionsWindow();
            window.FormClosed += new FormClosedEventHandler(modal_Closed);
           window.ShowDialog();
        }

        private void modal_Closed(object sender, EventArgs e)
        {
            StartDrawThread();
        }

        private void StartDrawThread()
        {
            StopDrawThread();
            drawThread = new Thread(new ThreadStart(this.captureLoop));
            drawThread.Start();
            while (!drawThread.IsAlive) ;
            Thread.Sleep(1);
        }

        private void form_Closed(object sender, EventArgs e)
        {
            StopDrawThread();
        }

        private void StopDrawThread()
        {
            if (drawThread != null)
            {
                drawThread.Abort();
                drawThread = null;
            }
        }

        private void captureLoop()
        {
            while (true)
            {
                if (Environment.TickCount - last > 35)
                {
                    Bitmap bitmap = ScreenCapturer.CaptureScreen(false, false);
                    last = Environment.TickCount;
                    if (bitmap != null)
                    {
                        pictureBox.Image = bitmap;
                    }
                }
            }
        }
    }
}