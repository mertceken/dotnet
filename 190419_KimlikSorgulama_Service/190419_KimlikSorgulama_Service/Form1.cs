using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _190419_KimlikSorgulama_Service.TCKimlikNoServiceReference;

namespace _190419_KimlikSorgulama_Service
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //using _190419_KimlikSorgulama_Service.TCKimlikNoServiceReference; eklenmeli
      
        }

        private void button1_Click(object sender, EventArgs e)
        {

            KPSPublicSoapClient sonuc = new KPSPublicSoapClient();

            
            long tc =Convert.ToInt64( maskedTextBoxTC.Text);
            string adi = textBoxAdi.Text.ToUpper();
            string soyadi = textBoxSoyadi.Text.ToUpper();
            int dogumyili =Convert.ToInt32(maskedTextBoxDogumyili.Text);
            bool gelen = sonuc.TCKimlikNoDogrula(tc, adi, soyadi, dogumyili);

            if (gelen)
            {

                MessageBox.Show("***********Nerelisin??************\nİçinden mi??");
            }
            else
            {
                MessageBox.Show("Bu ülkeden değilsin??");
            }
        }
    }
}
