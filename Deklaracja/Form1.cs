using System;
using System.IO;

namespace Deklaracja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonInformatyk_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxKwalifikacja.Items.Clear();
            comboBoxKwalifikacja.Items.Add("INF.03");
            comboBoxKwalifikacja.Items.Add("INF.02");
        }

        private void radioButtonProgramista_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxKwalifikacja.Items.Clear();
            comboBoxKwalifikacja.Items.Add("INF.03");
            comboBoxKwalifikacja.Items.Add("INF.04");
        }
    }
}