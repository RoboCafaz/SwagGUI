using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SwagGUI
{
    public partial class Interface : Form
    {

        private Button buttonCalibrate;
        private Label labelName;
        private Label labelClass;
        private Label labelIP;
        private Label labelPort;
        private ComboBox comboClass;
        private TextBox textName;
        private NumericUpDown spinnerPort;
        private TextBox textIP;
        private Button buttonBroadcast;
    }
}