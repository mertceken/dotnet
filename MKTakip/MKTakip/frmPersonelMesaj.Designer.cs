namespace MKTakip
{
    partial class frmPersonelMesaj
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
            this.btnMesajEkle = new System.Windows.Forms.Button();
            this.btnMesajGiden = new System.Windows.Forms.Button();
            this.btnMesajGelen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMesajEkle
            // 
            this.btnMesajEkle.Location = new System.Drawing.Point(78, 72);
            this.btnMesajEkle.Name = "btnMesajEkle";
            this.btnMesajEkle.Size = new System.Drawing.Size(75, 75);
            this.btnMesajEkle.TabIndex = 0;
            this.btnMesajEkle.Text = "Mesaj Ekle";
            this.btnMesajEkle.UseVisualStyleBackColor = true;
            this.btnMesajEkle.Click += new System.EventHandler(this.btnMesajEkle_Click);
            // 
            // btnMesajGiden
            // 
            this.btnMesajGiden.Location = new System.Drawing.Point(187, 72);
            this.btnMesajGiden.Name = "btnMesajGiden";
            this.btnMesajGiden.Size = new System.Drawing.Size(75, 75);
            this.btnMesajGiden.TabIndex = 1;
            this.btnMesajGiden.Text = "Giden Mesaj ";
            this.btnMesajGiden.UseVisualStyleBackColor = true;
            this.btnMesajGiden.Click += new System.EventHandler(this.btnMesajGiden_Click);
            // 
            // btnMesajGelen
            // 
            this.btnMesajGelen.Location = new System.Drawing.Point(320, 72);
            this.btnMesajGelen.Name = "btnMesajGelen";
            this.btnMesajGelen.Size = new System.Drawing.Size(75, 75);
            this.btnMesajGelen.TabIndex = 2;
            this.btnMesajGelen.Text = "Gelen Mesaj";
            this.btnMesajGelen.UseVisualStyleBackColor = true;
            this.btnMesajGelen.Click += new System.EventHandler(this.btnMesajGelen_Click);
            // 
            // frmPersonelMesaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 416);
            this.Controls.Add(this.btnMesajGelen);
            this.Controls.Add(this.btnMesajGiden);
            this.Controls.Add(this.btnMesajEkle);
            this.Name = "frmPersonelMesaj";
            this.Text = "frmPersonelMesaj";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMesajEkle;
        private System.Windows.Forms.Button btnMesajGiden;
        private System.Windows.Forms.Button btnMesajGelen;
    }
}