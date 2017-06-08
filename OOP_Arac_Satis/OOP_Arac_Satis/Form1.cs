using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Arac_Satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList veriler = new ArrayList();
        List<araba> arabalar = new List<araba>();
        List<motor> motorlar = new List<motor>();
        araba arb = new araba();
        araba arb2 = new araba();
        motor mtr = new motor();
        motor mtr2 = new motor();
        double indirimorani = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            
            arb.marka = "BMW";
            arb.model = "3.20";
            arb.motorGucu = "1600hp";
            arb.renk = "Mavi";
            arb.yil = "2015";
            arb.vitesTuru = "Manuel";
            arb.fiyat = 100000;
          
            
            arb2.marka = "Mercedes";
            arb2.model = "E Series";
            arb2.motorGucu = "2000hp";
            arb2.renk = "Mavi";
            arb2.yil = "2015";
            arb2.vitesTuru = "Otomatik";
            arb2.fiyat = 250000;

            
            mtr.fiyat = 80000;
            mtr.marka = "Honda";
            mtr.model = "CDR1000RR";
            mtr.renk = "Yeşil";
            mtr.motorGucu = "1000cc";
            mtr.vitesTuru = "Otomatik";
            mtr.yil = "2014";

           
            mtr2.fiyat = 60000;
            mtr2.marka = "Kawasiki";
            mtr2.model = "Ninja";
            mtr2.renk = "Koyu Yeşil";
            mtr2.motorGucu = "600cc";
            mtr2.vitesTuru = "Otomatik";
            mtr2.yil = "2015";

            arabalar.Add(arb);
            arabalar.Add(arb2);

            motorlar.Add(mtr);
            motorlar.Add(mtr2);



        }

        private void cbmTasit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmTasit.SelectedIndex == 0)
            {
                cbmMarka.DataSource = arabalar;
            }
            else
            {
                cbmMarka.DataSource = motorlar;
            }
        }

        private void cbmIndirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //İndirimsiz Fiyat
            if (cbmIndirim.SelectedIndex == 0)
            {
                lblToplam.ResetText();
                label4.Visible = false;
                
                if (cbmTasit.SelectedIndex == 0)
                {
                    if (cbmMarka.SelectedIndex == 0)
                    {
                        lblKDV.Text = arb.KDVhesapla().ToString();
                    }
                    else if (cbmMarka.SelectedIndex == 1)
                    {
                        lblKDV.Text = arb2.KDVhesapla().ToString();
                    }
                }
                else if (cbmTasit.SelectedIndex == 1)
                {
                    if (cbmMarka.SelectedIndex == 0)
                    {
                        lblKDV.Text = mtr.KDVhesapla().ToString();
                    }
                    else if (cbmMarka.SelectedIndex == 1)
                    {
                        lblKDV.Text = mtr2.KDVhesapla().ToString();
                    }
                }
            }
                //Engelli İndirimi Uygulanan Fiyat LİSTESİ!!!!
            else if (cbmIndirim.SelectedIndex == 1)
            {
                label4.Visible = true;
                    
                if (cbmTasit.SelectedIndex == 0)
                {
                    if (cbmMarka.SelectedIndex == 0)
                    {
                        lblKDV.Text = arb.KDVhesapla().ToString();
                        lblToplam.Text = arb.EngelliMusteri().ToString();
                    }
                    else if (cbmMarka.SelectedIndex == 1)
                    {
                        lblKDV.Text = arb2.KDVhesapla().ToString();
                        lblToplam.Text = arb2.EngelliMusteri().ToString();
                    }
                }
                else if (cbmTasit.SelectedIndex == 1)
                {
                    if (cbmMarka.SelectedIndex == 0)
                    {
                        lblKDV.Text = mtr.KDVhesapla().ToString();
                        lblToplam.Text = mtr.EngelliMusteri().ToString();
                    }
                    else if (cbmMarka.SelectedIndex == 1)
                    {
                        lblKDV.Text = mtr2.KDVhesapla().ToString();
                        lblToplam.Text = mtr2.EngelliMusteri().ToString();
                    }
                }
            }
            else if (cbmIndirim.SelectedIndex == 2)
            {

                if (cbmTasit.SelectedIndex == 0)
                {
                    if (cbmMarka.SelectedIndex == 0)
                    {
                        lblKDV.Text = arb.KDVhesapla().ToString();
                        lblToplam.Text = arb.VIP().ToString();
                    }
                    else if (cbmMarka.SelectedIndex == 1)
                    {
                        lblKDV.Text = arb2.KDVhesapla().ToString();
                        lblToplam.Text = arb2.VIP().ToString();
                    }
                }
                else if (cbmTasit.SelectedIndex == 1)
                {
                    if (cbmMarka.SelectedIndex == 0)
                    {
                        lblKDV.Text = mtr.KDVhesapla().ToString();
                        lblToplam.Text = mtr.VIP().ToString();
                    }
                    else if (cbmMarka.SelectedIndex == 1)
                    {
                        lblKDV.Text = mtr2.KDVhesapla().ToString();
                        lblToplam.Text = mtr2.VIP().ToString();
                    }
                }
            }
        }
        
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            tasit tst = (tasit)cbmMarka.SelectedItem;
                 lstbSatilan.Items.Add(tst);
                 veriler.Add(tst);
         
           
           
        }
        
        private void lstbSatilan_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstbSatilanDetay.Items.Clear();
           
            tasit tst = (tasit)lstbSatilan.SelectedItem;
                lstbSatilanDetay.Items.Add(tst.marka);
                lstbSatilanDetay.Items.Add(tst.model);
                lstbSatilanDetay.Items.Add(tst.renk);
           
                if (cbmIndirim.SelectedIndex == 0)
                {
                    lstbSatilanDetay.Items.Add(tst.KDVhesapla().ToString());
                }
                else if (cbmIndirim.SelectedIndex == 1)
                {
                    lstbSatilanDetay.Items.Add(tst.EngelliMusteri().ToString()+" " + "(Bu ürün engelli müşteriye satılmıştır)");
                }
                else if(cbmIndirim.SelectedIndex == 2)
                {
                    lstbSatilanDetay.Items.Add(tst.VIP().ToString() + " "+ "(Bu ürün VIP müşteriye satılmıştır)");
                }

               
                
            
            
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
            if (textBox1.Text != null)
            { 
                indirimorani = Convert.ToDouble(textBox1.Text);
                label4.Visible = true;
                lblToplam.Text = arb.indirim(indirimorani).ToString();
            }
        }
    }
}
