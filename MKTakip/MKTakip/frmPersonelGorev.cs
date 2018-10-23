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
    public partial class frmPersonelGorev : Form
    {
        public frmPersonelGorev()
        {
            InitializeComponent();
        }

        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            frmPersonelGorevEkle frm = new frmPersonelGorevEkle();
            this.Hide();
            frm.Show();
        }

        private void btnGelenGorev_Click(object sender, EventArgs e)
        {
            frmPersonelGelenGorev frm = new frmPersonelGelenGorev();
            this.Hide();
            frm.Show();

        }

        private void btnGidenGorev_Click(object sender, EventArgs e)
        {
            frmPersonelGidenGorev frm = new frmPersonelGidenGorev();
            this.Hide();
            frm.Show();
        }

        private void btnGorevDetay_Click(object sender, EventArgs e)
        {
            frmPersonelGorevDetay frm = new frmPersonelGorevDetay();
            this.Hide();
            frm.Show();
        }
    }
}
