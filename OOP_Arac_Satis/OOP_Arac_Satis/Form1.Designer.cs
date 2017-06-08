namespace OOP_Arac_Satis
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
            this.cbmTasit = new System.Windows.Forms.ComboBox();
            this.cbmMarka = new System.Windows.Forms.ComboBox();
            this.cbmIndirim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lstbSatilan = new System.Windows.Forms.ListBox();
            this.lstbSatilanDetay = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKDV = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbmTasit
            // 
            this.cbmTasit.FormattingEnabled = true;
            this.cbmTasit.Items.AddRange(new object[] {
            "Araba",
            "Motor"});
            this.cbmTasit.Location = new System.Drawing.Point(119, 15);
            this.cbmTasit.Name = "cbmTasit";
            this.cbmTasit.Size = new System.Drawing.Size(121, 21);
            this.cbmTasit.TabIndex = 0;
            this.cbmTasit.SelectedIndexChanged += new System.EventHandler(this.cbmTasit_SelectedIndexChanged);
            // 
            // cbmMarka
            // 
            this.cbmMarka.FormattingEnabled = true;
            this.cbmMarka.Location = new System.Drawing.Point(119, 43);
            this.cbmMarka.Name = "cbmMarka";
            this.cbmMarka.Size = new System.Drawing.Size(121, 21);
            this.cbmMarka.TabIndex = 1;
            // 
            // cbmIndirim
            // 
            this.cbmIndirim.FormattingEnabled = true;
            this.cbmIndirim.Items.AddRange(new object[] {
            "İndirimsiz",
            "Engelli",
            "Vip"});
            this.cbmIndirim.Location = new System.Drawing.Point(119, 79);
            this.cbmIndirim.Name = "cbmIndirim";
            this.cbmIndirim.Size = new System.Drawing.Size(121, 21);
            this.cbmIndirim.TabIndex = 2;
            this.cbmIndirim.SelectedIndexChanged += new System.EventHandler(this.cbmIndirim_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Taşıt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "İndirim";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(152, 208);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(121, 23);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Sat";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "İndirimli Fiyat";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(241, 183);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(0, 13);
            this.lblToplam.TabIndex = 6;
            // 
            // lstbSatilan
            // 
            this.lstbSatilan.FormattingEnabled = true;
            this.lstbSatilan.Location = new System.Drawing.Point(385, 15);
            this.lstbSatilan.Name = "lstbSatilan";
            this.lstbSatilan.Size = new System.Drawing.Size(158, 108);
            this.lstbSatilan.TabIndex = 7;
            this.lstbSatilan.SelectedIndexChanged += new System.EventHandler(this.lstbSatilan_SelectedIndexChanged);
            // 
            // lstbSatilanDetay
            // 
            this.lstbSatilanDetay.FormattingEnabled = true;
            this.lstbSatilanDetay.Location = new System.Drawing.Point(385, 148);
            this.lstbSatilanDetay.Name = "lstbSatilanDetay";
            this.lstbSatilanDetay.Size = new System.Drawing.Size(158, 134);
            this.lstbSatilanDetay.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fiyat";
            // 
            // lblKDV
            // 
            this.lblKDV.AutoSize = true;
            this.lblKDV.Location = new System.Drawing.Point(241, 148);
            this.lblKDV.Name = "lblKDV";
            this.lblKDV.Size = new System.Drawing.Size(0, 13);
            this.lblKDV.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "İndirim Oranı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 300);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblKDV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstbSatilanDetay);
            this.Controls.Add(this.lstbSatilan);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbmIndirim);
            this.Controls.Add(this.cbmMarka);
            this.Controls.Add(this.cbmTasit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmTasit;
        private System.Windows.Forms.ComboBox cbmMarka;
        private System.Windows.Forms.ComboBox cbmIndirim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.ListBox lstbSatilan;
        private System.Windows.Forms.ListBox lstbSatilanDetay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKDV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}

