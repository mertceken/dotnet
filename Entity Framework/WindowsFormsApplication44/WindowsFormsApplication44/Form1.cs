using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication44.model;

namespace WindowsFormsApplication44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Entities db = new Entities();
        private void button1_Click(object sender, EventArgs e)
        {
            Product prd = new Product();
            prd.ProductName = textBox1.Text;
            prd.UnitPrice =Convert.ToDecimal( textBox2.Text);
            db.Products.Add(prd);
            db.SaveChanges();
            MessageBox.Show("Ürününüz Eklenmiştir");
            urungoster();
        }
        void urungoster()
        {
            listBox1.DataSource = db.Products.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            urungoster();
        }
        Product prd = new Product();
        private void button2_Click(object sender, EventArgs e)
        {
            prd.ProductName = textBox1.Text;
            prd.UnitPrice =Convert.ToDecimal( textBox2.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");
            urungoster();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            prd = (Product)listBox1.SelectedItem;
            textBox1.Text = prd.ProductName;
            textBox2.Text = prd.UnitPrice.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.Products.Remove(prd);
            db.SaveChanges();
            MessageBox.Show("Ürününüz Silinmiştir");
            urungoster();
        }
    }
}
