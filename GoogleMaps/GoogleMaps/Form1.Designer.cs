namespace GoogleMaps
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
            this.lblSehir = new System.Windows.Forms.Label();
            this.lblİlce = new System.Windows.Forms.Label();
            this.lblUlke = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.txtİlce = new System.Windows.Forms.TextBox();
            this.txtUlke = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Location = new System.Drawing.Point(25, 18);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(37, 13);
            this.lblSehir.TabIndex = 0;
            this.lblSehir.Text = "Şehir :";
            // 
            // lblİlce
            // 
            this.lblİlce.AutoSize = true;
            this.lblİlce.Location = new System.Drawing.Point(207, 18);
            this.lblİlce.Name = "lblİlce";
            this.lblİlce.Size = new System.Drawing.Size(27, 13);
            this.lblİlce.TabIndex = 1;
            this.lblİlce.Text = "İlçe:";
            // 
            // lblUlke
            // 
            this.lblUlke.AutoSize = true;
            this.lblUlke.Location = new System.Drawing.Point(387, 18);
            this.lblUlke.Name = "lblUlke";
            this.lblUlke.Size = new System.Drawing.Size(32, 13);
            this.lblUlke.TabIndex = 2;
            this.lblUlke.Text = "Ülke:";
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(68, 15);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(100, 20);
            this.txtSehir.TabIndex = 3;
            // 
            // txtİlce
            // 
            this.txtİlce.Location = new System.Drawing.Point(240, 15);
            this.txtİlce.Name = "txtİlce";
            this.txtİlce.Size = new System.Drawing.Size(122, 20);
            this.txtİlce.TabIndex = 4;
            // 
            // txtUlke
            // 
            this.txtUlke.Location = new System.Drawing.Point(425, 15);
            this.txtUlke.Name = "txtUlke";
            this.txtUlke.Size = new System.Drawing.Size(122, 20);
            this.txtUlke.TabIndex = 5;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(28, 55);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(726, 275);
            this.webBrowser1.TabIndex = 6;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(601, 15);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(120, 23);
            this.btnAra.TabIndex = 7;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 354);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txtUlke);
            this.Controls.Add(this.txtİlce);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.lblUlke);
            this.Controls.Add(this.lblİlce);
            this.Controls.Add(this.lblSehir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.Label lblİlce;
        private System.Windows.Forms.Label lblUlke;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.TextBox txtİlce;
        private System.Windows.Forms.TextBox txtUlke;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnAra;
    }
}

