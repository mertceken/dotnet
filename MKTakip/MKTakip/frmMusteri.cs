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
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle frm = new frmMusteriEkle();
            this.Hide();
            frm.Show();
        }

        private void btnMusteriListe_Click(object sender, EventArgs e)
        {
            frmMusteriListe frm = new frmMusteriListe();
            this.Hide();
            frm.Show();
        }

        private void frmMusteri_Load(object sender, EventArgs e)
        {

        }
    }
}
