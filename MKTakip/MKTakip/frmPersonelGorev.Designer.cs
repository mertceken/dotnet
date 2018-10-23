namespace MKTakip
{
    partial class frmPersonelGorev
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
            this.btnGorevEkle = new System.Windows.Forms.Button();
            this.btnGelenGorev = new System.Windows.Forms.Button();
            this.btnGidenGorev = new System.Windows.Forms.Button();
            this.mnGorevTakvim = new System.Windows.Forms.MonthCalendar();
            this.btnGorevDetay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGorevEkle
            // 
            this.btnGorevEkle.Location = new System.Drawing.Point(39, 36);
            this.btnGorevEkle.Name = "btnGorevEkle";
            this.btnGorevEkle.Size = new System.Drawing.Size(116, 90);
            this.btnGorevEkle.TabIndex = 0;
            this.btnGorevEkle.Text = "Görev Ekle";
            this.btnGorevEkle.UseVisualStyleBackColor = true;
            this.btnGorevEkle.Click += new System.EventHandler(this.btnGorevEkle_Click);
            // 
            // btnGelenGorev
            // 
            this.btnGelenGorev.Location = new System.Drawing.Point(166, 36);
            this.btnGelenGorev.Name = "btnGelenGorev";
            this.btnGelenGorev.Size = new System.Drawing.Size(116, 90);
            this.btnGelenGorev.TabIndex = 1;
            this.btnGelenGorev.Text = "Gelen Görev";
            this.btnGelenGorev.UseVisualStyleBackColor = true;
            this.btnGelenGorev.Click += new System.EventHandler(this.btnGelenGorev_Click);
            // 
            // btnGidenGorev
            // 
            this.btnGidenGorev.Location = new System.Drawing.Point(312, 36);
            this.btnGidenGorev.Name = "btnGidenGorev";
            this.btnGidenGorev.Size = new System.Drawing.Size(116, 90);
            this.btnGidenGorev.TabIndex = 2;
            this.btnGidenGorev.Text = "Giden Görev";
            this.btnGidenGorev.UseVisualStyleBackColor = true;
            this.btnGidenGorev.Click += new System.EventHandler(this.btnGidenGorev_Click);
            // 
            // mnGorevTakvim
            // 
            this.mnGorevTakvim.Location = new System.Drawing.Point(48, 166);
            this.mnGorevTakvim.Name = "mnGorevTakvim";
            this.mnGorevTakvim.TabIndex = 3;
            // 
            // btnGorevDetay
            // 
            this.btnGorevDetay.Location = new System.Drawing.Point(460, 36);
            this.btnGorevDetay.Name = "btnGorevDetay";
            this.btnGorevDetay.Size = new System.Drawing.Size(116, 90);
            this.btnGorevDetay.TabIndex = 4;
            this.btnGorevDetay.Text = "Görev Detay";
            this.btnGorevDetay.UseVisualStyleBackColor = true;
            this.btnGorevDetay.Click += new System.EventHandler(this.btnGorevDetay_Click);
            // 
            // frmPersonelGorev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 377);
            this.Controls.Add(this.btnGorevDetay);
            this.Controls.Add(this.mnGorevTakvim);
            this.Controls.Add(this.btnGidenGorev);
            this.Controls.Add(this.btnGelenGorev);
            this.Controls.Add(this.btnGorevEkle);
            this.Name = "frmPersonelGorev";
            this.Text = "frmPersonelGorev";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGorevEkle;
        private System.Windows.Forms.Button btnGelenGorev;
        private System.Windows.Forms.Button btnGidenGorev;
        private System.Windows.Forms.MonthCalendar mnGorevTakvim;
        private System.Windows.Forms.Button btnGorevDetay;
    }
}