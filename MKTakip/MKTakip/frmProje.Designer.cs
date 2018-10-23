namespace MKTakip
{
    partial class frmProje
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
            this.btnTablo = new System.Windows.Forms.Button();
            this.btnProjeEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTablo
            // 
            this.btnTablo.Location = new System.Drawing.Point(320, 112);
            this.btnTablo.Name = "btnTablo";
            this.btnTablo.Size = new System.Drawing.Size(75, 72);
            this.btnTablo.TabIndex = 1;
            this.btnTablo.Text = "Proje Tablo :";
            this.btnTablo.UseVisualStyleBackColor = true;
            this.btnTablo.Click += new System.EventHandler(this.btnTablo_Click);
            // 
            // btnProjeEkle
            // 
            this.btnProjeEkle.Location = new System.Drawing.Point(144, 112);
            this.btnProjeEkle.Name = "btnProjeEkle";
            this.btnProjeEkle.Size = new System.Drawing.Size(75, 72);
            this.btnProjeEkle.TabIndex = 2;
            this.btnProjeEkle.Text = "Proje Ekle :";
            this.btnProjeEkle.UseVisualStyleBackColor = true;
            this.btnProjeEkle.Click += new System.EventHandler(this.btnProjeEkle_Click);
            // 
            // frmProje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 388);
            this.Controls.Add(this.btnProjeEkle);
            this.Controls.Add(this.btnTablo);
            this.Name = "frmProje";
            this.Text = "frmProje";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTablo;
        private System.Windows.Forms.Button btnProjeEkle;
    }
}