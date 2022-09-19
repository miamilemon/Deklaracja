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
                labelKwalifikacja.Text = "Administracja i eksploatacja systemów komputerowych, urządzeń peryferyjnych i lokalnych sieci komputerowych";
            }
            else if (comboBoxKwalifikacja.Text == "INF.04")
            {
                labelKwalifikacja.Text = "Projektowanie, programowanie i testowanie aplikacji";
            }
        }

        private void radioButtonPierwszy_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxPisemna.Enabled = false;
            checkBoxPraktyczna.Enabled = false;
        }

        private void radioButtonKolejny_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxPisemna.Enabled = true;
            checkBoxPraktyczna.Enabled = true;
        }

        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            textBoxNazwisko.Clear();
            textBoxImie.Clear();
            maskedTextBoxData.Clear();
            textBoxMiejsceUr.Clear();
            maskedTextBoxPESEL.Clear();
            textBoxMiejscowosc.Clear();
            textBoxUlica.Clear();
            maskedTextBoxKodPocztowy.Clear();
            textBoxPoczta.Clear();
            maskedTextBoxTelefon.Clear();
            textBoxMail.Clear();
            comboBoxTermin.SelectedItem = null;
            comboBoxKwalifikacja.SelectedItem = null;
            radioButtonInformatyk.Checked = false;
            radioButtonProgramista.Checked = false;
            radioButtonPierwszy.Checked = false;
            radioButtonKolejny.Checked = false;
            checkBoxPisemna.Checked = false;
            checkBoxPraktyczna.Checked = false;
            checkBoxPisemna.Enabled = false;
            checkBoxPraktyczna.Enabled = false;
            labelKwalifikacja.Text = "";
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "Deklaracja "+textBoxImie.Text+" "+textBoxNazwisko.Text+" "+DateTime.Now.ToString()+".txt";
            save.Filter = "Plik tekstowy | *.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.WriteLine(richTextBoxPole.Text);
                writer.Dispose();
                writer.Close();

            }
        }

        private void buttonZatwierdz_Click(object sender, EventArgs e)
        {
            bool isOk = false;
            if (string.IsNullOrEmpty(textBoxNazwisko.Text))
            {
                isOk = false;
                textBoxNazwisko.BackColor = Color.Red;
                MessageBox.Show("Pole nazwisko jest puste");
            }
            else
            {
                isOk = true;
                textBoxNazwisko.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(textBoxImie.Text))
            {
                isOk = false;
                textBoxImie.BackColor = Color.Red;
                MessageBox.Show("Pole imie jest puste");
            }
            else
            {
                isOk = true;
                textBoxImie.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(maskedTextBoxData.Text))
            {
                isOk = false;
                maskedTextBoxData.BackColor = Color.Red;
                MessageBox.Show("Pole data urodzenia jest puste");
            }
            else
            {
                isOk = true;
                maskedTextBoxData.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(textBoxMiejsceUr.Text))
            {
                isOk = false;
                textBoxMiejsceUr.BackColor = Color.Red;
                MessageBox.Show("Pole miejsce urodzenia jest puste");
            }
            else
            {
                isOk = true;
                textBoxMiejsceUr.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(maskedTextBoxPESEL.Text))
            {
                isOk = false;
                maskedTextBoxPESEL.BackColor = Color.Red;
                MessageBox.Show("Pole PESEL jest puste");
            }
            else
            {
                isOk = true;
                maskedTextBoxPESEL.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(textBoxMiejscowosc.Text))
            {
                isOk = false;
                textBoxMiejscowosc.BackColor = Color.Red;
                MessageBox.Show("Pole miejscowosc jest puste");
            }
            else
            {
                isOk = true;
                textBoxMiejscowosc.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(textBoxUlica.Text))
            {
                isOk = false;
                textBoxUlica.BackColor = Color.Red;
                MessageBox.Show("Pole ulica i numer domu jest puste");
            }
            else
            {
                isOk = true;
                textBoxUlica.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(maskedTextBoxKodPocztowy.Text))
            {
                isOk = false;
                maskedTextBoxKodPocztowy.BackColor = Color.Red;
                MessageBox.Show("Pole kod pocztowy jest puste");
            }
            else
            {
                isOk = true;
                maskedTextBoxKodPocztowy.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(textBoxPoczta.Text))
            {
                isOk = false;
                textBoxPoczta.BackColor = Color.Red;
                MessageBox.Show("Pole poczta jest puste");
            }
            else
            {
                isOk = true;
                textBoxPoczta.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(maskedTextBoxTelefon.Text))
            {
                isOk = false;
                maskedTextBoxTelefon.BackColor = Color.Red;
                MessageBox.Show("Pole nr telefonu jest puste");
            }
            else
            {
                isOk = true;
                maskedTextBoxTelefon.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(textBoxMail.Text))
            {
                isOk = false;
                textBoxMail.BackColor = Color.Red;
                MessageBox.Show("Pole mail jest puste");
            }
            else
            {
                isOk = true;
                textBoxMail.BackColor = Color.White;
            }

            if (comboBoxTermin.SelectedIndex == -1)
            {
                isOk = false;
                comboBoxTermin.BackColor = Color.Red;
                MessageBox.Show("Nie wybrano terminu");
            }
            else
            {
                isOk = true;
                comboBoxTermin.BackColor = Color.White;
            }

            if (comboBoxKwalifikacja.SelectedIndex == -1)
            {
                isOk = false;
                comboBoxKwalifikacja.BackColor = Color.Red;
                MessageBox.Show("Nie wybrano kwalifikacji");
            }
            else
            {
                isOk = true;
                comboBoxKwalifikacja.BackColor = Color.White;
            }

            if (radioButtonInformatyk.Checked == false && radioButtonProgramista.Checked == false)
            {
                isOk = false;
                radioButtonInformatyk.BackColor = Color.Red;
                radioButtonProgramista.BackColor = Color.Red;
                MessageBox.Show("Wybierz zawód");
            }
            else
            {
                isOk = true;
                radioButtonInformatyk.BackColor = Color.White;
                radioButtonProgramista.BackColor = Color.White;      
            }

            if (radioButtonPierwszy.Checked == false && radioButtonKolejny.Checked == false)
            {
                isOk = false;
                radioButtonPierwszy.BackColor = Color.Red;
                radioButtonKolejny.BackColor = Color.Red;
                MessageBox.Show("Wybierz który raz przystępujesz do egzaminu");
                
            }
            else
            {
                isOk = true;
                radioButtonKolejny.BackColor = Color.White;
                radioButtonPierwszy.BackColor = Color.White;
            }

            if (textBoxImie.Text.EndsWith("A") == true)
            {
                int iostatnie = Convert.ToInt32(maskedTextBoxPESEL.Text.ToString().Substring(9, 1));
                if (iostatnie % 2 == 0)
                {
                    isOk = true;
                }
                else
                {
                    isOk = false;
                    MessageBox.Show("PESEL się nie zgadza!");
                }
            }

            if (isOk == true)
            {
                string cyfrowy = "";
                string nazwaZaw = "";
                if (radioButtonProgramista.Checked == true)
                {
                    cyfrowy = "351406";
                    nazwaZaw = "technik programista";

                }
                else
                {
                    cyfrowy = "351203";
                    nazwaZaw = "technik informatyk";
                }
                string ktoryToJuzRaz = "";
                if(radioButtonKolejny.Checked == true)
                {
                    if (checkBoxPisemna.Checked == true && checkBoxPraktyczna.Checked == false)
                    {
                        ktoryToJuzRaz = "poraz kolejny do części pisemnej";
                    }
                    else if (checkBoxPraktyczna.Checked == true && checkBoxPisemna.Checked == false)
                    {
                        ktoryToJuzRaz = "poraz kolejny do części praktycznej";
                    }
                    else
                    {
                        ktoryToJuzRaz = "poraz kolejny do części pisemnej i praktycznej";
                    }
                }
                else{
                    ktoryToJuzRaz = "poraz pierwszy";
                }
                richTextBoxPole.Text = "Deklaruje przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie przeprowadzonego w terminie" + " " + comboBoxTermin.Text + "\r\n" + "\r\n" +
                    "Dane osobowe ucznia" + "\r\n" +
                    " Nazwisko: \t" + textBoxNazwisko.Text + "\r\n" +
                    " Imie(imiona):\t" + textBoxImie.Text + "\r\n" +
                    " Data i miejsce urodzenia: \t" + maskedTextBoxData.Text + " , " + textBoxMiejsceUr.Text + "\r\n" +
                    " Numer Pesel:\t " + maskedTextBoxPESEL.Text + "\r\n" + "\r\n" +
                    "Adres korenspondencyjny" + "\r\n" +
                    " miejscowość:\t " + textBoxMiejsceUr.Text + "\r\n" +
                    " ulica i numer domu:\t " + textBoxUlica.Text + "\r\n" +
                    " kod pocztowy i poczta:\t " + maskedTextBoxKodPocztowy.Text + " , " + textBoxPoczta.Text + "\r\n" +
                    " nr telefonu z kierunkowym:\t " + maskedTextBoxTelefon.Text + "\r\n" +
                    " mail:\t " + textBoxMail.Text + "\r\n" + "\r\n" +
                    "Deklaruje przystąpienie do egazminu poraz " + ktoryToJuzRaz
                    + "\r\n" + "\r\n" +
                    "Oznaczenie kwalifikacji zgodne z podstawą programow¹: " + comboBoxKwalifikacja.Text + "\r\n" +
                    "Nazwa kwalifikacji: " + labelKwalifikacja.Text + "." + "\r\n" + "\r\n" +
                    "Symbol cyfrowy zawodu: " + cyfrowy + "\r\n" +
                    "Nazwa zawodu: " + nazwaZaw;
            }

        }
    }
}