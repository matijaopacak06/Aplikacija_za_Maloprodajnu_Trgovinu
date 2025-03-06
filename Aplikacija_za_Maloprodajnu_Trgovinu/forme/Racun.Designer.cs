namespace Aplikacija_za_Maloprodajnu_Trgovinu.forme
{
    partial class Racun
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
            this.Kupac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Količina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Popust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukupna_cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrikaziRacun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kupac,
            this.Kategorija,
            this.Proizvod,
            this.Cijena,
            this.Količina,
            this.Popust,
            this.Ukupna_cijena});
            this.dataGridView1.Location = new System.Drawing.Point(11, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1254, 286);
            this.dataGridView1.TabIndex = 7;
            // 
            // Kupac
            // 
            this.Kupac.HeaderText = "Kupac";
            this.Kupac.MinimumWidth = 8;
            this.Kupac.Name = "Kupac";
            this.Kupac.Width = 150;
            // 
            // Kategorija
            // 
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.MinimumWidth = 6;
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.Width = 125;
            // 
            // Proizvod
            // 
            this.Proizvod.HeaderText = "Proizvod";
            this.Proizvod.MinimumWidth = 8;
            this.Proizvod.Name = "Proizvod";
            this.Proizvod.Width = 150;
            // 
            // Cijena
            // 
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 8;
            this.Cijena.Name = "Cijena";
            this.Cijena.Width = 150;
            // 
            // Količina
            // 
            this.Količina.HeaderText = "Količina";
            this.Količina.MinimumWidth = 8;
            this.Količina.Name = "Količina";
            this.Količina.Width = 150;
            // 
            // Popust
            // 
            this.Popust.HeaderText = "Popust";
            this.Popust.MinimumWidth = 8;
            this.Popust.Name = "Popust";
            this.Popust.Width = 150;
            // 
            // Ukupna_cijena
            // 
            this.Ukupna_cijena.HeaderText = "Ukupna_cijena";
            this.Ukupna_cijena.MinimumWidth = 8;
            this.Ukupna_cijena.Name = "Ukupna_cijena";
            this.Ukupna_cijena.Width = 150;
            // 
            // btnPrikaziRacun
            // 
            this.btnPrikaziRacun.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.btnPrikaziRacun.Location = new System.Drawing.Point(11, 308);
            this.btnPrikaziRacun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrikaziRacun.Name = "btnPrikaziRacun";
            this.btnPrikaziRacun.Size = new System.Drawing.Size(134, 41);
            this.btnPrikaziRacun.TabIndex = 13;
            this.btnPrikaziRacun.Text = "Prikaži račun";
            this.btnPrikaziRacun.UseVisualStyleBackColor = true;
            // 
            // Racun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Aplikacija_za_Maloprodajnu_Trgovinu.Properties.Resources.racun;
            this.ClientSize = new System.Drawing.Size(1276, 360);
            this.Controls.Add(this.btnPrikaziRacun);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Racun";
            this.Text = "Racun";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kupac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Popust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ukupna_cijena;
        private System.Windows.Forms.Button btnPrikaziRacun;
    }
}