namespace MKTakip
{
    partial class frmPersonel
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
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnGorev = new System.Windows.Forms.Button();
            this.btnPersonelListe = new System.Windows.Forms.Button();
            this.btnMesaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(67, 88);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(75, 71);
            this.btnPersonelEkle.TabIndex = 0;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnGorev
            // 
            this.btnGorev.Location = new System.Drawing.Point(286, 88);
            this.btnGorev.Name = "btnGorev";
            this.btnGorev.Size = new System.Drawing.Size(75, 71);
            this.btnGorev.TabIndex = 1;
            this.btnGorev.Text = "Görev Yöneticisi";
            this.btnGorev.UseVisualStyleBackColor = true;
            this.btnGorev.Click += new System.EventHandler(this.btnGorev_Click);
            // 
            // btnPersonelListe
            // 
            this.btnPersonelListe.Location = new System.Drawing.Point(176, 86);
            this.btnPersonelListe.Name = "btnPersonelListe";
            this.btnPersonelListe.Size = new System.Drawing.Size(75, 71);
            this.btnPersonelListe.TabIndex = 2;
            this.btnPersonelListe.Text = "Personel Liste";
            this.btnPersonelListe.UseVisualStyleBackColor = true;
            this.btnPersonelListe.Click += new System.EventHandler(this.btnPersonelListe_Click);
            // 
            // btnMesaj
            // 
            this.btnMesaj.Location = new System.Drawing.Point(397, 88);
            this.btnMesaj.Name = "btnMesaj";
            this.btnMesaj.Size = new System.Drawing.Size(75, 71);
            this.btnMesaj.TabIndex = 3;
            this.btnMesaj.Text = "Mesajlar :";
            this.btnMesaj.UseVisualStyleBackColor = true;
            this.btnMesaj.Click += new System.EventHandler(this.btnMesaj_Click);
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 396);
            this.Controls.Add(this.btnMesaj);
            this.Controls.Add(this.btnPersonelListe);
            this.Controls.Add(this.btnGorev);
            this.Controls.Add(this.btnPersonelEkle);
            this.Name = "frmPersonel";
            this.Text = "frmPersonel";
            this.Load += new System.EventHandler(this.frmPersonel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnGorev;
        private System.Windows.Forms.Button btnPersonelListe;
        private System.Windows.Forms.Button btnMesaj;
    }
}