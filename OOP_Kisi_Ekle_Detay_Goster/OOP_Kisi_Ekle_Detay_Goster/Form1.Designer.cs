namespace OOP_Kisi_Ekle_Detay_Goster
{
    partial class Form1
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
            this.btndetay = new System.Windows.Forms.Button();
            this.txtkisiadi = new System.Windows.Forms.TextBox();
            this.txtkisisoaydi = new System.Windows.Forms.TextBox();
            this.txtdogumyeri = new System.Windows.Forms.TextBox();
            this.txtbabaadi = new System.Windows.Forms.TextBox();
            this.dtpdogumtarih = new System.Windows.Forms.DateTimePicker();
            this.btnekle = new System.Windows.Forms.Button();
            this.lstbxdatabase = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndetay
            // 
            this.btndetay.Location = new System.Drawing.Point(646, 234);
            this.btndetay.Name = "btndetay";
            this.btndetay.Size = new System.Drawing.Size(120, 65);
            this.btndetay.TabIndex = 1;
            this.btndetay.Text = "Detay Göster";
            this.btndetay.UseVisualStyleBackColor = true;
            this.btndetay.Click += new System.EventHandler(this.btndetay_Click);
            // 
            // txtkisiadi
            // 
            this.txtkisiadi.Location = new System.Drawing.Point(593, 17);
            this.txtkisiadi.Name = "txtkisiadi";
            this.txtkisiadi.Size = new System.Drawing.Size(173, 20);
            this.txtkisiadi.TabIndex = 2;
            // 
            // txtkisisoaydi
            // 
            this.txtkisisoaydi.Location = new System.Drawing.Point(593, 60);
            this.txtkisisoaydi.Name = "txtkisisoaydi";
            this.txtkisisoaydi.Size = new System.Drawing.Size(173, 20);
            this.txtkisisoaydi.TabIndex = 3;
            // 
            // txtdogumyeri
            // 
            this.txtdogumyeri.Location = new System.Drawing.Point(593, 106);
            this.txtdogumyeri.Name = "txtdogumyeri";
            this.txtdogumyeri.Size = new System.Drawing.Size(173, 20);
            this.txtdogumyeri.TabIndex = 4;
            // 
            // txtbabaadi
            // 
            this.txtbabaadi.Location = new System.Drawing.Point(593, 152);
            this.txtbabaadi.Name = "txtbabaadi";
            this.txtbabaadi.Size = new System.Drawing.Size(173, 20);
            this.txtbabaadi.TabIndex = 5;
            // 
            // dtpdogumtarih
            // 
            this.dtpdogumtarih.Location = new System.Drawing.Point(593, 193);
            this.dtpdogumtarih.Name = "dtpdogumtarih";
            this.dtpdogumtarih.Size = new System.Drawing.Size(173, 20);
            this.dtpdogumtarih.TabIndex = 6;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(499, 233);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(129, 23);
            this.btnekle.TabIndex = 7;
            this.btnekle.Text = "Kişi Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // lstbxdatabase
            // 
            this.lstbxdatabase.FormattingEnabled = true;
            this.lstbxdatabase.Location = new System.Drawing.Point(191, 11);
            this.lstbxdatabase.Name = "lstbxdatabase";
            this.lstbxdatabase.Size = new System.Drawing.Size(120, 199);
            this.lstbxdatabase.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kişi Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kişi Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Doğum Yeri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Baba Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Doğum Tarihi";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(499, 276);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(129, 23);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Bilgi Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(360, 53);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(118, 20);
            this.txtAra.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "KİŞİ ARA";
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(379, 79);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(75, 23);
            this.btnara.TabIndex = 17;
            this.btnara.Text = "ARA";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 322);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbxdatabase);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dtpdogumtarih);
            this.Controls.Add(this.txtbabaadi);
            this.Controls.Add(this.txtdogumyeri);
            this.Controls.Add(this.txtkisisoaydi);
            this.Controls.Add(this.txtkisiadi);
            this.Controls.Add(this.btndetay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndetay;
        private System.Windows.Forms.TextBox txtkisiadi;
        private System.Windows.Forms.TextBox txtkisisoaydi;
        private System.Windows.Forms.TextBox txtdogumyeri;
        private System.Windows.Forms.TextBox txtbabaadi;
        private System.Windows.Forms.DateTimePicker dtpdogumtarih;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.ListBox lstbxdatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnara;
    }
}

