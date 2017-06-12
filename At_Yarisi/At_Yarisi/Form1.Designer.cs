namespace At_Yarisi
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
            this.components = new System.ComponentModel.Container();
            this.at1 = new System.Windows.Forms.PictureBox();
            this.at2 = new System.Windows.Forms.PictureBox();
            this.at3 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.finish = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblsunum = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.at1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.at2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.at3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finish)).BeginInit();
            this.SuspendLayout();
            // 
            // at1
            // 
            this.at1.BackColor = System.Drawing.Color.White;
            this.at1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.at1.Image = global::At_Yarisi.Properties.Resources.at1;
            this.at1.Location = new System.Drawing.Point(12, 12);
            this.at1.Name = "at1";
            this.at1.Size = new System.Drawing.Size(100, 50);
            this.at1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.at1.TabIndex = 0;
            this.at1.TabStop = false;
            // 
            // at2
            // 
            this.at2.Image = global::At_Yarisi.Properties.Resources.at2;
            this.at2.Location = new System.Drawing.Point(12, 88);
            this.at2.Name = "at2";
            this.at2.Size = new System.Drawing.Size(100, 50);
            this.at2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.at2.TabIndex = 0;
            this.at2.TabStop = false;
            // 
            // at3
            // 
            this.at3.Image = global::At_Yarisi.Properties.Resources.at3;
            this.at3.Location = new System.Drawing.Point(12, 174);
            this.at3.Name = "at3";
            this.at3.Size = new System.Drawing.Size(100, 50);
            this.at3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.at3.TabIndex = 0;
            this.at3.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 266);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(156, 37);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // finish
            // 
            this.finish.Image = global::At_Yarisi.Properties.Resources.indir;
            this.finish.Location = new System.Drawing.Point(698, 2);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(21, 245);
            this.finish.TabIndex = 0;
            this.finish.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 20);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(680, 20);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(680, 20);
            this.label3.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblsunum
            // 
            this.lblsunum.BackColor = System.Drawing.Color.Black;
            this.lblsunum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsunum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblsunum.Location = new System.Drawing.Point(174, 266);
            this.lblsunum.Name = "lblsunum";
            this.lblsunum.Size = new System.Drawing.Size(518, 86);
            this.lblsunum.TabIndex = 4;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(12, 309);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(156, 40);
            this.btnYeni.TabIndex = 5;
            this.btnYeni.Text = "Yeniden Başlat";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::At_Yarisi.Properties.Resources.images1;
            this.ClientSize = new System.Drawing.Size(721, 361);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.lblsunum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.at3);
            this.Controls.Add(this.at2);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.at1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.at1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.at2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.at3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox at1;
        private System.Windows.Forms.PictureBox at2;
        private System.Windows.Forms.PictureBox at3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox finish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblsunum;
        private System.Windows.Forms.Button btnYeni;
    }
}

