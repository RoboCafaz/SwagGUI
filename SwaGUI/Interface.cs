using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SwagGUI
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.buttonCalibrate = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.spinnerPort = new System.Windows.Forms.NumericUpDown();
            this.textIP = new System.Windows.Forms.TextBox();
            this.buttonBroadcast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerPort)).BeginInit();
            this.SuspendLayout();
            //
            // buttonCalibrate
            //
            this.buttonCalibrate.Location = new System.Drawing.Point(13, 117);
            this.buttonCalibrate.Name = "buttonCalibrate";
            this.buttonCalibrate.Size = new System.Drawing.Size(201, 23);
            this.buttonCalibrate.TabIndex = 0;
            this.buttonCalibrate.Text = "Calibrate";
            this.buttonCalibrate.UseVisualStyleBackColor = true;
            this.buttonCalibrate.Click += new EventHandler(buttonCalibrate_Click);
            //
            // labelName
            //
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(47, 67);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            //
            // labelClass
            //
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(50, 93);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(35, 13);
            this.labelClass.TabIndex = 2;
            this.labelClass.Text = "Class:";
            //
            // labelIP
            //
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(31, 15);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(54, 13);
            this.labelIP.TabIndex = 3;
            this.labelIP.Text = "Target IP:";
            //
            // labelPort
            //
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(22, 40);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(63, 13);
            this.labelPort.TabIndex = 4;
            this.labelPort.Text = "Target Port:";
            //
            // comboClass
            //
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Items.AddRange(new object[] {
            "Elementalist",
            "Engineer",
            "Guardian",
            "Mesmer",
            "Necromancer",
            "Ranger",
            "Thief",
            "Warrior"});
            this.comboClass.Location = new System.Drawing.Point(93, 90);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(121, 21);
            this.comboClass.TabIndex = 5;
            //
            // textName
            //
            this.textName.Location = new System.Drawing.Point(93, 64);
            this.textName.MaxLength = 24;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(121, 20);
            this.textName.TabIndex = 6;
            //
            // spinnerPort
            //
            this.spinnerPort.Location = new System.Drawing.Point(93, 38);
            this.spinnerPort.Name = "spinnerPort";
            this.spinnerPort.Size = new System.Drawing.Size(120, 20);
            this.spinnerPort.TabIndex = 7;
            //
            // textIP
            //
            this.textIP.Location = new System.Drawing.Point(93, 12);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(120, 20);
            this.textIP.TabIndex = 8;
            //
            // buttonBroadcast
            //
            this.buttonBroadcast.Location = new System.Drawing.Point(13, 146);
            this.buttonBroadcast.Name = "buttonBroadcast";
            this.buttonBroadcast.Size = new System.Drawing.Size(201, 23);
            this.buttonBroadcast.TabIndex = 9;
            this.buttonBroadcast.Text = "Start Reading";
            this.buttonBroadcast.UseVisualStyleBackColor = true;
            buttonBroadcast.Click += new EventHandler(buttonBroadcast_Click);
            //
            // Interface
            //
            this.ClientSize = new System.Drawing.Size(225, 262);
            this.Controls.Add(this.buttonBroadcast);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.spinnerPort);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.comboClass);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCalibrate);
            this.Name = "Interface";
            ((System.ComponentModel.ISupportInitialize)(this.spinnerPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void buttonCalibrate_Click(object sender, EventArgs e)
        {
            Bitmap bmp = ScreenCapturer.CaptureHealthArea();
            if (bmp != null)
            {
                bmp.Save("test.bmp", ImageFormat.Bmp);
            }
        }

        private void buttonBroadcast_Click(object sender, EventArgs e)
        {
            if (TimerHandler.TimerEnabled())
            {
                TimerHandler.StopTimer();
            }
            else
            {
                TimerHandler.StartTimer();
            }
        }
    }
}