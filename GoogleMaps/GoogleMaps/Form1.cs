using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleMaps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string sehir = txtSehir.Text;
            string ilce = txtİlce.Text;
            string ulke = txtUlke.Text;

            StringBuilder add = new StringBuilder("http://maps.google.com/maps?q=");

            add.Append(sehir);
            add.Append(ilce);
            add.Append(ulke);

            webBrowser1.Navigate(add.ToString());
        }
    }
}
