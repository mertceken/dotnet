using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Kisi_Ekle_Detay_Goster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void temizle() //ekleme işleminden sonra textbox ları temizlemek için oluşturuldu
        {
            txtbabaadi.Clear();
            txtdogumyeri.Clear();
            txtkisiadi.Clear();
            txtkisisoaydi.Clear();
            dtpdogumtarih.ResetText();
            txtAra.Clear();
            lstbxdatabase.ClearSelected();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            KisiBilgi ks = new KisiBilgi(); //kişi ekleme kodları
            ks.kisiadi = txtkisiadi.Text;
            ks.kisisoyad = txtkisisoaydi.Text;
            ks.dogumyeri = txtdogumyeri.Text;
            ks.babaadi = txtbabaadi.Text;
            ks.dogumtarih = dtpdogumtarih.Value;
            lstbxdatabase.Items.Add(ks);//listboxa veri ekliyo ancak sadece isim gösteriyyo kisibilgi sınıfında sadece isim değeri dnüyor çünkü
            temizle();
        }

        private void btndetay_Click(object sender, EventArgs e)
        {
            if (lstbxdatabase.SelectedIndex < 0)
            {
                MessageBox.Show("Detay görüntülemek istediğiniz veriyi seçiniz");
            }

            else
            {
                KisiBilgi ks = (KisiBilgi)lstbxdatabase.SelectedItem; //detay görüntülemek için
                txtkisiadi.Text = ks.kisiadi;
                txtkisisoaydi.Text = ks.kisisoyad;
                txtdogumyeri.Text = ks.dogumyeri;
                txtbabaadi.Text = ks.babaadi;
                dtpdogumtarih.Value = ks.dogumtarih;
            }
            
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           
            if (lstbxdatabase.SelectedIndex < 0 ) //güncelleme için
            {
                MessageBox.Show("Güncellemek istediğiniz veriyi seçiniz");
            }
            else
            {
                KisiBilgi ks = (KisiBilgi)lstbxdatabase.SelectedItem;
                ks.babaadi = txtbabaadi.Text;
                ks.dogumtarih = dtpdogumtarih.Value;
                ks.dogumyeri = txtdogumyeri.Text;
                ks.kisiadi = txtkisiadi.Text;
                ks.kisisoyad = txtkisisoaydi.Text;
                temizle();
            }
        }
        
        int i = 0; //listbox ta hiç veri yoksa yapılan kontrol için
        private void btnara_Click(object sender, EventArgs e) //arama yapmak için
        {
            if (i == lstbxdatabase.Items.Count)
            {
                MessageBox.Show("aradığınız öğe bulunamadı");
            }
            else
            {
                for (int j = 0; j < lstbxdatabase.Items.Count; j++)
                {
                    if (txtAra.Text == lstbxdatabase.Items[j].ToString())
                    {
                        lstbxdatabase.SelectedItem = lstbxdatabase.Items[j];
                        break;
                    }
                    
                }
               
            }
                
                
            
            
            

        }
    }
}
