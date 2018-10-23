namespace MKTakip
{
    partial class frmMusteri
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
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriListe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(151, 124);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(75, 63);
            this.btnMusteriEkle.TabIndex = 0;
            this.btnMusteriEkle.Text = "Yeni Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnMusteriListe
            // 
            this.btnMusteriListe.Location = new System.Drawing.Point(377, 123);
            this.btnMusteriListe.Name = "btnMusteriListe";
            this.btnMusteriListe.Size = new System.Drawing.Size(75, 64);
            this.btnMusteriListe.TabIndex = 1;
            this.btnMusteriListe.Text = "Müşteri Listesi";
            this.btnMusteriListe.UseVisualStyleBackColor = true;
            this.btnMusteriListe.Click += new System.EventHandler(this.btnMusteriListe_Click);
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 428);
            this.Controls.Add(this.btnMusteriListe);
            this.Controls.Add(this.btnMusteriEkle);
            this.Name = "frmMusteri";
            this.Text = "frmMusteri";
            this.Load += new System.EventHandler(this.frmMusteri_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriListe;
    }
}