namespace MKTakip
{
    partial class frmKasa
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
            this.btnKasaOdeme = new System.Windows.Forms.Button();
            this.btnKasaListe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKasaOdeme
            // 
            this.btnKasaOdeme.Location = new System.Drawing.Point(89, 135);
            this.btnKasaOdeme.Name = "btnKasaOdeme";
            this.btnKasaOdeme.Size = new System.Drawing.Size(126, 77);
            this.btnKasaOdeme.TabIndex = 0;
            this.btnKasaOdeme.Text = "Yeni Ödeme";
            this.btnKasaOdeme.UseVisualStyleBackColor = true;
            this.btnKasaOdeme.Click += new System.EventHandler(this.btnKasaOdeme_Click);
            // 
            // btnKasaListe
            // 
            this.btnKasaListe.Location = new System.Drawing.Point(335, 144);
            this.btnKasaListe.Name = "btnKasaListe";
            this.btnKasaListe.Size = new System.Drawing.Size(126, 77);
            this.btnKasaListe.TabIndex = 1;
            this.btnKasaListe.Text = "Ödeme Listesi ";
            this.btnKasaListe.UseVisualStyleBackColor = true;
            this.btnKasaListe.Click += new System.EventHandler(this.btnKasaListe_Click);
            // 
            // frmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 442);
            this.Controls.Add(this.btnKasaListe);
            this.Controls.Add(this.btnKasaOdeme);
            this.Name = "frmKasa";
            this.Text = "frmKasa";
            this.Load += new System.EventHandler(this.frmKasa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKasaOdeme;
        private System.Windows.Forms.Button btnKasaListe;
    }
}