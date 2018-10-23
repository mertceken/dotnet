namespace MKTakip
{
    partial class frmAnaPanel
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
            this.btnKasa = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnProje = new System.Windows.Forms.Button();
            this.btnHakkimizda = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKasa
            // 
            this.btnKasa.Location = new System.Drawing.Point(126, 182);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(114, 77);
            this.btnKasa.TabIndex = 1;
            this.btnKasa.Text = "Kasa";
            this.btnKasa.UseVisualStyleBackColor = true;
            this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Location = new System.Drawing.Point(281, 73);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(75, 74);
            this.btnUrunler.TabIndex = 2;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // btnPersonel
            // 
            this.btnPersonel.Location = new System.Drawing.Point(281, 182);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(75, 77);
            this.btnPersonel.TabIndex = 3;
            this.btnPersonel.Text = "Personel";
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnProje
            // 
            this.btnProje.Location = new System.Drawing.Point(381, 73);
            this.btnProje.Name = "btnProje";
            this.btnProje.Size = new System.Drawing.Size(75, 74);
            this.btnProje.TabIndex = 4;
            this.btnProje.Text = "Proje";
            this.btnProje.UseVisualStyleBackColor = true;
            this.btnProje.Click += new System.EventHandler(this.btnProje_Click);
            // 
            // btnHakkimizda
            // 
            this.btnHakkimizda.Location = new System.Drawing.Point(381, 182);
            this.btnHakkimizda.Name = "btnHakkimizda";
            this.btnHakkimizda.Size = new System.Drawing.Size(75, 77);
            this.btnHakkimizda.TabIndex = 5;
            this.btnHakkimizda.Text = "Hakkımızda";
            this.btnHakkimizda.UseVisualStyleBackColor = true;
            this.btnHakkimizda.Click += new System.EventHandler(this.btnHakkimizda_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(429, 328);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.Location = new System.Drawing.Point(126, 73);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(114, 77);
            this.btnMusteri.TabIndex = 7;
            this.btnMusteri.Text = "Müşteri";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // frmAnaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MKTakip.Properties.Resources.BACKGROUND;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 479);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnHakkimizda);
            this.Controls.Add(this.btnProje);
            this.Controls.Add(this.btnPersonel);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.btnKasa);
            this.DoubleBuffered = true;
            this.Name = "frmAnaPanel";
            this.Text = "frmAnaPanel";
            this.Load += new System.EventHandler(this.frmAnaPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnProje;
        private System.Windows.Forms.Button btnHakkimizda;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnMusteri;
    }
}