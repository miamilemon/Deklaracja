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

        private void comboBoxKwalifikacja_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKwalifikacja.Text == "INF.03")
            {
                labelKwalifikacja.Text = "Tworzenie i administrowanie stronami i aplikacjami internetowymi oraz bazami danych";
            }else if (comboBoxKwalifikacja.Text == "INF.02")
            {
                labelKwalifikacja.Text = "Administracja i eksploatacja systemów komputerowych, urz¹dzeñ peryferyjnych i lokalnych sieci komputerowych";
            }
            else if (comboBoxKwalifikacja.Text == "INF.04")
            {
                labelKwalifikacja.Text = "Projektowanie, programowanie i testowanie aplikacji";
            }
        }
    }
}