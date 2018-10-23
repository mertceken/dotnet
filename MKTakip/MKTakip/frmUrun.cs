using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKTakip
{
    public partial class frmUrun : Form
    {
        public frmUrun()
        {
            InitializeComponent();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            frmUrunEkle frm = new frmUrunEkle();
            this.Hide();
            frm.Show();
        }

        private void btnUrunListe_Click(object sender, EventArgs e)
        {
            frmUrunListe frm = new frmUrunListe();
            this.Hide();
            frm.Show();
        }
    }
}
