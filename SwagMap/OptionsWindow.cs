using System.Windows.Forms;
using System;
using System.Drawing;

namespace SwagMap
{
    public partial class OptionsWindow : Form
    {
        public OptionsWindow()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Options.Width = (int)spinnerWidth.Value;
            Options.Height = (int)spinnerWidth.Value;
            Options.Bottom = checkBottom.Checked;
            this.Dispose(true);
        }

        private void optionsWindow_Load(object sender, EventArgs e)
        {
            Bitmap image = null;
            while (image == null)
            {
                image = ScreenCapturer.CaptureScreen(true, true);
            }
            spinnerWidth.Maximum = image.Width / 2;
            spinnerHeight.Maximum = image.Height / 2;

            this.pictureBox.Image = image;
        }
    }
}