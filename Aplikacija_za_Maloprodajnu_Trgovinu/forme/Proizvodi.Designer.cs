namespace Aplikacija_za_Maloprodajnu_Trgovinu.forme
{
    partial class Proizvodi
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
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.ID_Proizvod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv_Proizvoda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis_proizvoda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Količina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jedinica_mjere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Proizvod,
            this.Kategorija,
            this.Naziv_Proizvoda,
            this.Opis_proizvoda,
            this.Količina,
            this.Cijena,
            this.Jedinica_mjere});
            this.dataGridView1.Location = new System.Drawing.Point(239, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 389);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.btnUcitaj.Location = new System.Drawing.Point(32, 83);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(151, 51);
            this.btnUcitaj.TabIndex = 12;
            this.btnUcitaj.Text = "Ucitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.btnSpremi.Location = new System.Drawing.Point(32, 219);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(151, 53);
            this.btnSpremi.TabIndex = 13;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            // 
            // ID_Proizvod
            // 
            this.ID_Proizvod.HeaderText = "ID_Proizvod";
            this.ID_Proizvod.MinimumWidth = 8;
            this.ID_Proizvod.Name = "ID_Proizvod";
            this.ID_Proizvod.Width = 150;
            // 
            // Kategorija
            // 
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.MinimumWidth = 8;
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.Width = 150;
            // 
            // Naziv_Proizvoda
            // 
            this.Naziv_Proizvoda.HeaderText = "Naziv_proizvoda";
            this.Naziv_Proizvoda.MinimumWidth = 8;
            this.Naziv_Proizvoda.Name = "Naziv_Proizvoda";
            this.Naziv_Proizvoda.Width = 150;
            // 
            // Opis_proizvoda
            // 
            this.Opis_proizvoda.HeaderText = "Opis_proizvoda";
            this.Opis_proizvoda.MinimumWidth = 8;
            this.Opis_proizvoda.Name = "Opis_proizvoda";
            this.Opis_proizvoda.Width = 150;
            // 
            // Količina
            // 
            this.Količina.HeaderText = "Količina";
            this.Količina.MinimumWidth = 8;
            this.Količina.Name = "Količina";
            this.Količina.Width = 150;
            // 
            // Cijena
            // 
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 8;
            this.Cijena.Name = "Cijena";
            this.Cijena.Width = 150;
            // 
            // Jedinica_mjere
            // 
            this.Jedinica_mjere.HeaderText = "Jedinica_mjere";
            this.Jedinica_mjere.MinimumWidth = 8;
            this.Jedinica_mjere.Name = "Jedinica_mjere";
            this.Jedinica_mjere.Width = 150;
            // 
            // Proizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikacija_za_Maloprodajnu_Trgovinu.Properties.Resources.trgovina2;
            this.ClientSize = new System.Drawing.Size(1253, 450);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Proizvodi";
            this.Text = "Proizvodi";
            this.Load += new System.EventHandler(this.Proizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Proizvod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv_Proizvoda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis_proizvoda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jedinica_mjere;
    }
}