namespace Aplikacija_za_Maloprodajnu_Trgovinu.forme
{
    partial class GlavnaForma
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
            this.btnKupac = new System.Windows.Forms.Button();
            this.btnKasa = new System.Windows.Forms.Button();
            this.btnRačun = new System.Windows.Forms.Button();
            this.btnProizvodi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKupac
            // 
            this.btnKupac.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKupac.Location = new System.Drawing.Point(12, 21);
            this.btnKupac.Name = "btnKupac";
            this.btnKupac.Size = new System.Drawing.Size(171, 63);
            this.btnKupac.TabIndex = 0;
            this.btnKupac.Text = "Kupac";
            this.btnKupac.UseVisualStyleBackColor = true;
            this.btnKupac.Click += new System.EventHandler(this.btnKupac_Click);
            // 
            // btnKasa
            // 
            this.btnKasa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKasa.Location = new System.Drawing.Point(12, 284);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(171, 63);
            this.btnKasa.TabIndex = 1;
            this.btnKasa.Text = "Kasa";
            this.btnKasa.UseVisualStyleBackColor = true;
            this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);
            // 
            // btnRačun
            // 
            this.btnRačun.BackColor = System.Drawing.Color.Transparent;
            this.btnRačun.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRačun.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRačun.Location = new System.Drawing.Point(446, 21);
            this.btnRačun.Name = "btnRačun";
            this.btnRačun.Size = new System.Drawing.Size(171, 63);
            this.btnRačun.TabIndex = 2;
            this.btnRačun.Text = "Račun";
            this.btnRačun.UseVisualStyleBackColor = false;
            this.btnRačun.Click += new System.EventHandler(this.btnRačun_Click);
            // 
            // btnProizvodi
            // 
            this.btnProizvodi.BackColor = System.Drawing.Color.Transparent;
            this.btnProizvodi.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProizvodi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProizvodi.Location = new System.Drawing.Point(446, 284);
            this.btnProizvodi.Name = "btnProizvodi";
            this.btnProizvodi.Size = new System.Drawing.Size(171, 63);
            this.btnProizvodi.TabIndex = 3;
            this.btnProizvodi.Text = "Proizvodi";
            this.btnProizvodi.UseVisualStyleBackColor = false;
            this.btnProizvodi.Click += new System.EventHandler(this.button1_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikacija_za_Maloprodajnu_Trgovinu.Properties.Resources.trgovina2;
            this.ClientSize = new System.Drawing.Size(644, 359);
            this.Controls.Add(this.btnProizvodi);
            this.Controls.Add(this.btnRačun);
            this.Controls.Add(this.btnKasa);
            this.Controls.Add(this.btnKupac);
            this.Name = "GlavnaForma";
            this.Text = "GlavnaForma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKupac;
        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.Button btnRačun;
        private System.Windows.Forms.Button btnProizvodi;
    }
}