namespace Deklaracja
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxDane = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPESEL = new System.Windows.Forms.MaskedTextBox();
            this.textBoxMiejsceUr = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.labelDataMiejsce = new System.Windows.Forms.Label();
            this.labelImiona = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.groupBoxAdres = new System.Windows.Forms.GroupBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.maskedTextBoxKodPocztowy = new System.Windows.Forms.MaskedTextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPoczta = new System.Windows.Forms.TextBox();
            this.textBoxUlica = new System.Windows.Forms.TextBox();
            this.textBoxMiejscowosc = new System.Windows.Forms.TextBox();
            this.labelNumerTel = new System.Windows.Forms.Label();
            this.labelKodPoczta = new System.Windows.Forms.Label();
            this.labelUlica = new System.Windows.Forms.Label();
            this.labelMiejscowosc = new System.Windows.Forms.Label();
            this.labelNaglowek = new System.Windows.Forms.Label();
            this.comboBoxTermin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonInformatyk = new System.Windows.Forms.RadioButton();
            this.radioButtonProgramista = new System.Windows.Forms.RadioButton();
            this.panelRadio = new System.Windows.Forms.Panel();
            this.comboBoxKwalifikacja = new System.Windows.Forms.ComboBox();
            this.labelKwalifikacja = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxPraktyczna = new System.Windows.Forms.CheckBox();
            this.checkBoxPisemna = new System.Windows.Forms.CheckBox();
            this.radioButtonKolejny = new System.Windows.Forms.RadioButton();
            this.radioButtonPierwszy = new System.Windows.Forms.RadioButton();
            this.richTextBoxPole = new System.Windows.Forms.RichTextBox();
            this.buttonWyczysc = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonZatwierdz = new System.Windows.Forms.Button();
            this.groupBoxDane.SuspendLayout();
            this.groupBoxAdres.SuspendLayout();
            this.panelRadio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDane
            // 
            this.groupBoxDane.Controls.Add(this.maskedTextBoxData);
            this.groupBoxDane.Controls.Add(this.maskedTextBoxPESEL);
            this.groupBoxDane.Controls.Add(this.textBoxMiejsceUr);
            this.groupBoxDane.Controls.Add(this.textBoxImie);
            this.groupBoxDane.Controls.Add(this.textBoxNazwisko);
            this.groupBoxDane.Controls.Add(this.labelPESEL);
            this.groupBoxDane.Controls.Add(this.labelDataMiejsce);
            this.groupBoxDane.Controls.Add(this.labelImiona);
            this.groupBoxDane.Controls.Add(this.labelNazwisko);
            this.groupBoxDane.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxDane.Location = new System.Drawing.Point(40, 60);
            this.groupBoxDane.Name = "groupBoxDane";
            this.groupBoxDane.Size = new System.Drawing.Size(517, 147);
            this.groupBoxDane.TabIndex = 0;
            this.groupBoxDane.TabStop = false;
            this.groupBoxDane.Text = "Dane osobowe ucznia";
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Location = new System.Drawing.Point(189, 79);
            this.maskedTextBoxData.Mask = "00/00/0000";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(91, 23);
            this.maskedTextBoxData.TabIndex = 10;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxPESEL
            // 
            this.maskedTextBoxPESEL.Location = new System.Drawing.Point(189, 108);
            this.maskedTextBoxPESEL.Mask = "00000000000";
            this.maskedTextBoxPESEL.Name = "maskedTextBoxPESEL";
            this.maskedTextBoxPESEL.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxPESEL.TabIndex = 9;
            // 
            // textBoxMiejsceUr
            // 
            this.textBoxMiejsceUr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxMiejsceUr.Location = new System.Drawing.Point(286, 79);
            this.textBoxMiejsceUr.Name = "textBoxMiejsceUr";
            this.textBoxMiejsceUr.Size = new System.Drawing.Size(193, 23);
            this.textBoxMiejsceUr.TabIndex = 8;
            // 
            // textBoxImie
            // 
            this.textBoxImie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxImie.Location = new System.Drawing.Point(189, 50);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(290, 23);
            this.textBoxImie.TabIndex = 5;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNazwisko.Location = new System.Drawing.Point(189, 21);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(290, 23);
            this.textBoxNazwisko.TabIndex = 4;
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(13, 108);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(81, 15);
            this.labelPESEL.TabIndex = 3;
            this.labelPESEL.Text = "Numer PESEL:";
            // 
            // labelDataMiejsce
            // 
            this.labelDataMiejsce.AutoSize = true;
            this.labelDataMiejsce.Location = new System.Drawing.Point(13, 79);
            this.labelDataMiejsce.Name = "labelDataMiejsce";
            this.labelDataMiejsce.Size = new System.Drawing.Size(138, 15);
            this.labelDataMiejsce.TabIndex = 2;
            this.labelDataMiejsce.Text = "Data i miejsce urodzenia:";
            // 
            // labelImiona
            // 
            this.labelImiona.AutoSize = true;
            this.labelImiona.Location = new System.Drawing.Point(13, 50);
            this.labelImiona.Name = "labelImiona";
            this.labelImiona.Size = new System.Drawing.Size(81, 15);
            this.labelImiona.TabIndex = 1;
            this.labelImiona.Text = "Imię (imiona):";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNazwisko.Location = new System.Drawing.Point(13, 21);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(60, 15);
            this.labelNazwisko.TabIndex = 0;
            this.labelNazwisko.Text = "Nazwisko:";
            // 
            // groupBoxAdres
            // 
            this.groupBoxAdres.Controls.Add(this.textBoxMail);
            this.groupBoxAdres.Controls.Add(this.maskedTextBoxKodPocztowy);
            this.groupBoxAdres.Controls.Add(this.labelEmail);
            this.groupBoxAdres.Controls.Add(this.maskedTextBoxTelefon);
            this.groupBoxAdres.Controls.Add(this.textBoxPoczta);
            this.groupBoxAdres.Controls.Add(this.textBoxUlica);
            this.groupBoxAdres.Controls.Add(this.textBoxMiejscowosc);
            this.groupBoxAdres.Controls.Add(this.labelNumerTel);
            this.groupBoxAdres.Controls.Add(this.labelKodPoczta);
            this.groupBoxAdres.Controls.Add(this.labelUlica);
            this.groupBoxAdres.Controls.Add(this.labelMiejscowosc);
            this.groupBoxAdres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxAdres.Location = new System.Drawing.Point(40, 213);
            this.groupBoxAdres.Name = "groupBoxAdres";
            this.groupBoxAdres.Size = new System.Drawing.Size(517, 157);
            this.groupBoxAdres.TabIndex = 1;
            this.groupBoxAdres.TabStop = false;
            this.groupBoxAdres.Text = "Adres korespondencyjny";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(329, 116);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(150, 23);
            this.textBoxMail.TabIndex = 18;
            // 
            // maskedTextBoxKodPocztowy
            // 
            this.maskedTextBoxKodPocztowy.Location = new System.Drawing.Point(189, 87);
            this.maskedTextBoxKodPocztowy.Mask = "00-999";
            this.maskedTextBoxKodPocztowy.Name = "maskedTextBoxKodPocztowy";
            this.maskedTextBoxKodPocztowy.Size = new System.Drawing.Size(91, 23);
            this.maskedTextBoxKodPocztowy.TabIndex = 17;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(298, 119);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(33, 15);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "mail:";
            // 
            // maskedTextBoxTelefon
            // 
            this.maskedTextBoxTelefon.Location = new System.Drawing.Point(189, 116);
            this.maskedTextBoxTelefon.Mask = "+99 000-000-000";
            this.maskedTextBoxTelefon.Name = "maskedTextBoxTelefon";
            this.maskedTextBoxTelefon.Size = new System.Drawing.Size(103, 23);
            this.maskedTextBoxTelefon.TabIndex = 15;
            // 
            // textBoxPoczta
            // 
            this.textBoxPoczta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPoczta.Location = new System.Drawing.Point(286, 87);
            this.textBoxPoczta.Name = "textBoxPoczta";
            this.textBoxPoczta.Size = new System.Drawing.Size(193, 23);
            this.textBoxPoczta.TabIndex = 7;
            // 
            // textBoxUlica
            // 
            this.textBoxUlica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxUlica.Location = new System.Drawing.Point(189, 58);
            this.textBoxUlica.Name = "textBoxUlica";
            this.textBoxUlica.Size = new System.Drawing.Size(290, 23);
            this.textBoxUlica.TabIndex = 5;
            // 
            // textBoxMiejscowosc
            // 
            this.textBoxMiejscowosc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxMiejscowosc.Location = new System.Drawing.Point(189, 29);
            this.textBoxMiejscowosc.Name = "textBoxMiejscowosc";
            this.textBoxMiejscowosc.Size = new System.Drawing.Size(290, 23);
            this.textBoxMiejscowosc.TabIndex = 4;
            // 
            // labelNumerTel
            // 
            this.labelNumerTel.AutoSize = true;
            this.labelNumerTel.Location = new System.Drawing.Point(13, 116);
            this.labelNumerTel.Name = "labelNumerTel";
            this.labelNumerTel.Size = new System.Drawing.Size(151, 15);
            this.labelNumerTel.TabIndex = 3;
            this.labelNumerTel.Text = "nr telefonu z kierunkowym:";
            // 
            // labelKodPoczta
            // 
            this.labelKodPoczta.AutoSize = true;
            this.labelKodPoczta.Location = new System.Drawing.Point(13, 87);
            this.labelKodPoczta.Name = "labelKodPoczta";
            this.labelKodPoczta.Size = new System.Drawing.Size(128, 15);
            this.labelKodPoczta.TabIndex = 2;
            this.labelKodPoczta.Text = "kod pocztowy i poczta:";
            // 
            // labelUlica
            // 
            this.labelUlica.AutoSize = true;
            this.labelUlica.Location = new System.Drawing.Point(13, 58);
            this.labelUlica.Name = "labelUlica";
            this.labelUlica.Size = new System.Drawing.Size(114, 15);
            this.labelUlica.TabIndex = 1;
            this.labelUlica.Text = "ulica i numer domu:";
            // 
            // labelMiejscowosc
            // 
            this.labelMiejscowosc.AutoSize = true;
            this.labelMiejscowosc.Location = new System.Drawing.Point(13, 29);
            this.labelMiejscowosc.Name = "labelMiejscowosc";
            this.labelMiejscowosc.Size = new System.Drawing.Size(78, 15);
            this.labelMiejscowosc.TabIndex = 0;
            this.labelMiejscowosc.Text = "miejscowość:";
            // 
            // labelNaglowek
            // 
            this.labelNaglowek.AutoSize = true;
            this.labelNaglowek.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNaglowek.Location = new System.Drawing.Point(89, 23);
            this.labelNaglowek.Name = "labelNaglowek";
            this.labelNaglowek.Size = new System.Drawing.Size(417, 25);
            this.labelNaglowek.TabIndex = 2;
            this.labelNaglowek.Text = "DEKLARACJA PRZYSTĄPIENIA DO EGZAMINU";
            // 
            // comboBoxTermin
            // 
            this.comboBoxTermin.FormattingEnabled = true;
            this.comboBoxTermin.Items.AddRange(new object[] {
            "styczeń",
            "czerwiec"});
            this.comboBoxTermin.Location = new System.Drawing.Point(258, 410);
            this.comboBoxTermin.Name = "comboBoxTermin";
            this.comboBoxTermin.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTermin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie\r\nprz" +
    "eprowadzanego w terminie";
            // 
            // radioButtonInformatyk
            // 
            this.radioButtonInformatyk.AutoSize = true;
            this.radioButtonInformatyk.Location = new System.Drawing.Point(3, 15);
            this.radioButtonInformatyk.Name = "radioButtonInformatyk";
            this.radioButtonInformatyk.Size = new System.Drawing.Size(125, 19);
            this.radioButtonInformatyk.TabIndex = 5;
            this.radioButtonInformatyk.TabStop = true;
            this.radioButtonInformatyk.Text = "technik informatyk";
            this.radioButtonInformatyk.UseVisualStyleBackColor = true;
            this.radioButtonInformatyk.CheckedChanged += new System.EventHandler(this.radioButtonInformatyk_CheckedChanged);
            // 
            // radioButtonProgramista
            // 
            this.radioButtonProgramista.AutoSize = true;
            this.radioButtonProgramista.Location = new System.Drawing.Point(191, 15);
            this.radioButtonProgramista.Name = "radioButtonProgramista";
            this.radioButtonProgramista.Size = new System.Drawing.Size(131, 19);
            this.radioButtonProgramista.TabIndex = 6;
            this.radioButtonProgramista.TabStop = true;
            this.radioButtonProgramista.Text = "technik programista";
            this.radioButtonProgramista.UseVisualStyleBackColor = true;
            this.radioButtonProgramista.CheckedChanged += new System.EventHandler(this.radioButtonProgramista_CheckedChanged);
            // 
            // panelRadio
            // 
            this.panelRadio.Controls.Add(this.radioButtonInformatyk);
            this.panelRadio.Controls.Add(this.radioButtonProgramista);
            this.panelRadio.Location = new System.Drawing.Point(139, 439);
            this.panelRadio.Name = "panelRadio";
            this.panelRadio.Size = new System.Drawing.Size(325, 48);
            this.panelRadio.TabIndex = 7;
            // 
            // comboBoxKwalifikacja
            // 
            this.comboBoxKwalifikacja.FormattingEnabled = true;
            this.comboBoxKwalifikacja.Location = new System.Drawing.Point(65, 493);
            this.comboBoxKwalifikacja.Name = "comboBoxKwalifikacja";
            this.comboBoxKwalifikacja.Size = new System.Drawing.Size(121, 23);
            this.comboBoxKwalifikacja.TabIndex = 8;
            this.comboBoxKwalifikacja.SelectedIndexChanged += new System.EventHandler(this.comboBoxKwalifikacja_SelectedIndexChanged);
            // 
            // labelKwalifikacja
            // 
            this.labelKwalifikacja.AutoSize = true;
            this.labelKwalifikacja.Location = new System.Drawing.Point(192, 496);
            this.labelKwalifikacja.Name = "labelKwalifikacja";
            this.labelKwalifikacja.Size = new System.Drawing.Size(124, 15);
            this.labelKwalifikacja.TabIndex = 9;
            this.labelKwalifikacja.Text = "                                       ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxPraktyczna);
            this.panel1.Controls.Add(this.checkBoxPisemna);
            this.panel1.Controls.Add(this.radioButtonKolejny);
            this.panel1.Controls.Add(this.radioButtonPierwszy);
            this.panel1.Location = new System.Drawing.Point(73, 532);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 40);
            this.panel1.TabIndex = 10;
            // 
            // checkBoxPraktyczna
            // 
            this.checkBoxPraktyczna.AutoSize = true;
            this.checkBoxPraktyczna.Enabled = false;
            this.checkBoxPraktyczna.Location = new System.Drawing.Point(357, 12);
            this.checkBoxPraktyczna.Name = "checkBoxPraktyczna";
            this.checkBoxPraktyczna.Size = new System.Drawing.Size(86, 19);
            this.checkBoxPraktyczna.TabIndex = 3;
            this.checkBoxPraktyczna.Text = "praktycznej";
            this.checkBoxPraktyczna.UseVisualStyleBackColor = true;
            // 
            // checkBoxPisemna
            // 
            this.checkBoxPisemna.AutoSize = true;
            this.checkBoxPisemna.Enabled = false;
            this.checkBoxPisemna.Location = new System.Drawing.Point(274, 11);
            this.checkBoxPisemna.Name = "checkBoxPisemna";
            this.checkBoxPisemna.Size = new System.Drawing.Size(77, 19);
            this.checkBoxPisemna.TabIndex = 2;
            this.checkBoxPisemna.Text = "pisemnej,";
            this.checkBoxPisemna.UseVisualStyleBackColor = true;
            // 
            // radioButtonKolejny
            // 
            this.radioButtonKolejny.AutoSize = true;
            this.radioButtonKolejny.Location = new System.Drawing.Point(119, 11);
            this.radioButtonKolejny.Name = "radioButtonKolejny";
            this.radioButtonKolejny.Size = new System.Drawing.Size(149, 19);
            this.radioButtonKolejny.TabIndex = 1;
            this.radioButtonKolejny.TabStop = true;
            this.radioButtonKolejny.Text = "po raz kolejny do części";
            this.radioButtonKolejny.UseVisualStyleBackColor = true;
            this.radioButtonKolejny.CheckedChanged += new System.EventHandler(this.radioButtonKolejny_CheckedChanged);
            // 
            // radioButtonPierwszy
            // 
            this.radioButtonPierwszy.AutoSize = true;
            this.radioButtonPierwszy.Location = new System.Drawing.Point(3, 11);
            this.radioButtonPierwszy.Name = "radioButtonPierwszy";
            this.radioButtonPierwszy.Size = new System.Drawing.Size(105, 19);
            this.radioButtonPierwszy.TabIndex = 0;
            this.radioButtonPierwszy.TabStop = true;
            this.radioButtonPierwszy.Text = "po raz pierwszy";
            this.radioButtonPierwszy.UseVisualStyleBackColor = true;
            this.radioButtonPierwszy.CheckedChanged += new System.EventHandler(this.radioButtonPierwszy_CheckedChanged);
            // 
            // richTextBoxPole
            // 
            this.richTextBoxPole.Location = new System.Drawing.Point(585, 23);
            this.richTextBoxPole.Name = "richTextBoxPole";
            this.richTextBoxPole.Size = new System.Drawing.Size(444, 549);
            this.richTextBoxPole.TabIndex = 11;
            this.richTextBoxPole.Text = "";
            // 
            // buttonWyczysc
            // 
            this.buttonWyczysc.Location = new System.Drawing.Point(585, 596);
            this.buttonWyczysc.Name = "buttonWyczysc";
            this.buttonWyczysc.Size = new System.Drawing.Size(232, 23);
            this.buttonWyczysc.TabIndex = 12;
            this.buttonWyczysc.Text = "Wyczyść";
            this.buttonWyczysc.UseVisualStyleBackColor = true;
            this.buttonWyczysc.Click += new System.EventHandler(this.buttonWyczysc_Click);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(833, 596);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(196, 23);
            this.buttonZapisz.TabIndex = 13;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // buttonZatwierdz
            // 
            this.buttonZatwierdz.Location = new System.Drawing.Point(338, 596);
            this.buttonZatwierdz.Name = "buttonZatwierdz";
            this.buttonZatwierdz.Size = new System.Drawing.Size(219, 23);
            this.buttonZatwierdz.TabIndex = 14;
            this.buttonZatwierdz.Text = "Zatwierdź";
            this.buttonZatwierdz.UseVisualStyleBackColor = true;
            this.buttonZatwierdz.Click += new System.EventHandler(this.buttonZatwierdz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 631);
            this.Controls.Add(this.buttonZatwierdz);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.buttonWyczysc);
            this.Controls.Add(this.richTextBoxPole);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelKwalifikacja);
            this.Controls.Add(this.comboBoxKwalifikacja);
            this.Controls.Add(this.panelRadio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTermin);
            this.Controls.Add(this.labelNaglowek);
            this.Controls.Add(this.groupBoxAdres);
            this.Controls.Add(this.groupBoxDane);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Deklaracja";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDane.ResumeLayout(false);
            this.groupBoxDane.PerformLayout();
            this.groupBoxAdres.ResumeLayout(false);
            this.groupBoxAdres.PerformLayout();
            this.panelRadio.ResumeLayout(false);
            this.panelRadio.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxDane;
        private TextBox textBoxImie;
        private TextBox textBoxNazwisko;
        private Label labelPESEL;
        private Label labelDataMiejsce;
        private Label labelImiona;
        private Label labelNazwisko;
        private GroupBox groupBoxAdres;
        private Label labelEmail;
        private TextBox textBoxPoczta;
        private TextBox textBoxUlica;
        private TextBox textBoxMiejscowosc;
        private Label labelNumerTel;
        private Label labelKodPoczta;
        private Label labelUlica;
        private Label labelMiejscowosc;
        private Label labelNaglowek;
        private ComboBox comboBoxTermin;
        private Label label1;
        private RadioButton radioButtonInformatyk;
        private RadioButton radioButtonProgramista;
        private Panel panelRadio;
        private ComboBox comboBoxKwalifikacja;
        private Label labelKwalifikacja;
        private Panel panel1;
        private CheckBox checkBoxPraktyczna;
        private CheckBox checkBoxPisemna;
        private RadioButton radioButtonKolejny;
        private RadioButton radioButtonPierwszy;
        private RichTextBox richTextBoxPole;
        private Button buttonWyczysc;
        private Button buttonZapisz;
        private Button buttonZatwierdz;
        private TextBox textBoxMail;
        private MaskedTextBox maskedTextBoxKodPocztowy;
        private MaskedTextBox maskedTextBoxTelefon;
        private MaskedTextBox maskedTextBoxData;
        private MaskedTextBox maskedTextBoxPESEL;
        private TextBox textBoxMiejsceUr;
    }
}