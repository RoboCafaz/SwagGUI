using System;
using System.Drawing;
namespace SwagMap
{
    partial class OptionsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.spinnerWidth = new System.Windows.Forms.NumericUpDown();
            this.spinnerHeight = new System.Windows.Forms.NumericUpDown();
            this.checkBottom = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(598, 391);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(540, 406);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(70, 22);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Okay";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // spinnerWidth
            // 
            this.spinnerWidth.Location = new System.Drawing.Point(430, 406);
            this.spinnerWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinnerWidth.Name = "spinnerWidth";
            this.spinnerWidth.Size = new System.Drawing.Size(49, 20);
            this.spinnerWidth.TabIndex = 8;
            this.spinnerWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // spinnerHeight
            // 
            this.spinnerHeight.Location = new System.Drawing.Point(485, 406);
            this.spinnerHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinnerHeight.Name = "spinnerHeight";
            this.spinnerHeight.Size = new System.Drawing.Size(49, 20);
            this.spinnerHeight.TabIndex = 9;
            this.spinnerHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBottom
            // 
            this.checkBottom.AutoSize = true;
            this.checkBottom.Location = new System.Drawing.Point(365, 407);
            this.checkBottom.Name = "checkBottom";
            this.checkBottom.Size = new System.Drawing.Size(59, 17);
            this.checkBottom.TabIndex = 10;
            this.checkBottom.Text = "Bottom";
            this.checkBottom.UseVisualStyleBackColor = true;
            // 
            // OptionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 434);
            this.ControlBox = false;
            this.Controls.Add(this.checkBottom);
            this.Controls.Add(this.spinnerHeight);
            this.Controls.Add(this.spinnerWidth);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonClose);
            this.Name = "OptionsWindow";
            this.Text = "Configuration";
            this.TopMost = true;
            this.Load += new System.EventHandler(optionsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.NumericUpDown spinnerWidth;
        private System.Windows.Forms.NumericUpDown spinnerHeight;
        private System.Windows.Forms.CheckBox checkBottom;
    }
}