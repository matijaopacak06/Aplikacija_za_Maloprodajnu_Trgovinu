namespace Aplikacija_za_Maloprodajnu_Trgovinu.forme
{
    partial class Pocetna
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxNazivProizvoda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownKolicina = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKategorija = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIzbriši = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnIzdajRacun = new System.Windows.Forms.Button();
            this.btnDodajProizvoda = new System.Windows.Forms.Button();
            this.btnDodajKupca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(435, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(433, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxNazivProizvoda
            // 
            this.textBoxNazivProizvoda.Location = new System.Drawing.Point(233, 107);
            this.textBoxNazivProizvoda.Multiline = true;
            this.textBoxNazivProizvoda.Name = "textBoxNazivProizvoda";
            this.textBoxNazivProizvoda.Size = new System.Drawing.Size(134, 33);
            this.textBoxNazivProizvoda.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv Proizvoda:";
            // 
            // numericUpDownKolicina
            // 
            this.numericUpDownKolicina.Location = new System.Drawing.Point(234, 195);
            this.numericUpDownKolicina.Name = "numericUpDownKolicina";
            this.numericUpDownKolicina.Size = new System.Drawing.Size(133, 28);
            this.numericUpDownKolicina.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(44, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kolicina:";
            // 
            // comboBoxKategorija
            // 
            this.comboBoxKategorija.FormattingEnabled = true;
            this.comboBoxKategorija.Items.AddRange(new object[] {
            "Hrana",
            "Piće",
            "Higijena",
            "Kućanske potrepštine"});
            this.comboBoxKategorija.Location = new System.Drawing.Point(233, 34);
            this.comboBoxKategorija.Name = "comboBoxKategorija";
            this.comboBoxKategorija.Size = new System.Drawing.Size(134, 30);
            this.comboBoxKategorija.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(44, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kategorija:";
            // 
            // btnIzbriši
            // 
            this.btnIzbriši.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.btnIzbriši.Location = new System.Drawing.Point(234, 310);
            this.btnIzbriši.Name = "btnIzbriši";
            this.btnIzbriši.Size = new System.Drawing.Size(151, 51);
            this.btnIzbriši.TabIndex = 10;
            this.btnIzbriši.Text = "Izbriši proizvod";
            this.btnIzbriši.UseVisualStyleBackColor = true;
            // 
            // btnUredi
            // 
            this.btnUredi.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.btnUredi.Location = new System.Drawing.Point(435, 310);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(151, 51);
            this.btnUredi.TabIndex = 11;
            this.btnUredi.Text = "Uredi proizvod";
            this.btnUredi.UseVisualStyleBackColor = true;
            // 
            // btnIzdajRacun
            // 
            this.btnIzdajRacun.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.btnIzdajRacun.Location = new System.Drawing.Point(699, 383);
            this.btnIzdajRacun.Name = "btnIzdajRacun";
            this.btnIzdajRacun.Size = new System.Drawing.Size(151, 51);
            this.btnIzdajRacun.TabIndex = 12;
            this.btnIzdajRacun.Text = "Izdaj  Racun";
            this.btnIzdajRacun.UseVisualStyleBackColor = true;
            this.btnIzdajRacun.Click += new System.EventHandler(this.btnIzdajRacun_Click);
            // 
            // btnDodajProizvoda
            // 
            this.btnDodajProizvoda.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.btnDodajProizvoda.Location = new System.Drawing.Point(17, 310);
            this.btnDodajProizvoda.Name = "btnDodajProizvoda";
            this.btnDodajProizvoda.Size = new System.Drawing.Size(151, 51);
            this.btnDodajProizvoda.TabIndex = 9;
            this.btnDodajProizvoda.Text = "Dodaj proizvod";
            this.btnDodajProizvoda.UseVisualStyleBackColor = true;
            this.btnDodajProizvoda.Click += new System.EventHandler(this.btnDodajProizvoda_Click);
            // 
            // btnDodajKupca
            // 
            this.btnDodajKupca.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.btnDodajKupca.Location = new System.Drawing.Point(17, 383);
            this.btnDodajKupca.Name = "btnDodajKupca";
            this.btnDodajKupca.Size = new System.Drawing.Size(151, 51);
            this.btnDodajKupca.TabIndex = 13;
            this.btnDodajKupca.Text = "Dodaj kupca";
            this.btnDodajKupca.UseVisualStyleBackColor = true;
            this.btnDodajKupca.Click += new System.EventHandler(this.btnDodajKupca_Click);
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Aplikacija_za_Maloprodajnu_Trgovinu.Properties.Resources.trgovina2;
            this.ClientSize = new System.Drawing.Size(889, 495);
            this.Controls.Add(this.btnDodajKupca);
            this.Controls.Add(this.btnIzdajRacun);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnIzbriši);
            this.Controls.Add(this.btnDodajProizvoda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxKategorija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownKolicina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNazivProizvoda);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "Pocetna";
            this.Text = "Pocetna";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxNazivProizvoda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownKolicina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKategorija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIzbriši;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnIzdajRacun;
        private System.Windows.Forms.Button btnDodajProizvoda;
        private System.Windows.Forms.Button btnDodajKupca;
    }
}