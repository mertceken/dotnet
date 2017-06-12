using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DialogResult sonuc;
        int att1, att2, att3;
        private void timer1_Tick(object sender, EventArgs e)
        {

            Random rnd = new Random();

            at1.Left += rnd.Next(1, 15);
            at2.Left += rnd.Next(1, 15);
            at3.Left += rnd.Next(1, 15);

            if (at1.Left + at1.Width > finish.Left)
            {
                timer1.Stop();
               sonuc = MessageBox.Show("1. At Yarışı Kazandı","Devam Etmek İstiyormusun?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                
            }
            else if (at2.Left + at2.Width > finish.Left)
            {
                timer1.Stop();
                sonuc = MessageBox.Show("2. At Yarışı Kazandı", "Devam Etmek İstiyormusun?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            }
            else if(at3.Left + at3.Width > finish.Left)
            {
                timer1.Stop();
                sonuc = MessageBox.Show("3. At Yarışı Kazandı", "Devam Etmek İstiyormusun?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            }

            if (at1.Left > at2.Left && at1.Left > at3.Left )
            {
                lblsunum.Text = "1. At Önde Gidiyor...";
            }
            else if (at2.Left > at3.Left && at2.Left > at1.Left)
	         {
            lblsunum.Text = "2. At Önde Gidiyor..,";
	         }
            else if(at3.Left > at1.Left && at3.Left> at2.Left)
            {
                lblsunum.Text = "3. At Önde Gidiyor...";
            }
            if (sonuc == System.Windows.Forms.DialogResult.Yes)
            {
                at1.Left = att1;
                at2.Left = att2;
                at3.Left = att3;
            }
            else if (sonuc == System.Windows.Forms.DialogResult.No)
            {
                this.Close();
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            lblsunum.Text = "Yarış Başladı";
            
                timer1.Start();
      

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            att1 = at1.Left;
            att2 = at2.Left;
            att3 = at3.Left;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            //Yeniden Başlat Butonuna Tıklandığı zaman başlaması için pictureBox'ların left değerini ilk değerlerine atarız
            //ve timerı yeniden başlatırız

            //at1.Left = att1;
            //at2.Left = att2;
            //at3.Left = att3;
            //timer1.Start();
        }
    }
}
