namespace MKTakip
{
    partial class frmUrun
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
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunListe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(135, 96);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(75, 62);
            this.btnUrunEkle.TabIndex = 0;
            this.btnUrunEkle.Text = "Ürün Ekle ";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunListe
            // 
            this.btnUrunListe.Location = new System.Drawing.Point(312, 124);
            this.btnUrunListe.Name = "btnUrunListe";
            this.btnUrunListe.Size = new System.Drawing.Size(75, 23);
            this.btnUrunListe.TabIndex = 1;
            this.btnUrunListe.Text = "Ürün Listesi";
            this.btnUrunListe.UseVisualStyleBackColor = true;
            this.btnUrunListe.Click += new System.EventHandler(this.btnUrunListe_Click);
            // 
            // frmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 440);
            this.Controls.Add(this.btnUrunListe);
            this.Controls.Add(this.btnUrunEkle);
            this.Name = "frmUrun";
            this.Text = "frmUrun";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunListe;
    }
}