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
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }

        private void frmPersonel_Load(object sender, EventArgs e)
        {

        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            frmPersonelEkle frm = new frmPersonelEkle();
            this.Hide();
            frm.Show();
        }

        private void btnPersonelListe_Click(object sender, EventArgs e)
        {
            frmPersonelListe frm = new frmPersonelListe();
            this.Hide();
            frm.Show();
        }

        private void btnGorev_Click(object sender, EventArgs e)
        {
            frmPersonelGorev frm = new frmPersonelGorev();
            this.Hide();
            frm.Show();
        }

        private void btnMesaj_Click(object sender, EventArgs e)
        {
            frmPersonelMesaj frm = new frmPersonelMesaj();
            this.Hide();
            frm.Show();

        }
    }
}
