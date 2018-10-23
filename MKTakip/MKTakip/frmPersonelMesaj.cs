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
    public partial class frmPersonelMesaj : Form
    {
        public frmPersonelMesaj()
        {
            InitializeComponent();
        }

        private void btnMesajEkle_Click(object sender, EventArgs e)
        {
            frmPersonelMesajEkle frm = new frmPersonelMesajEkle();
            this.Hide();
            frm.Show();

        }

        private void btnMesajGiden_Click(object sender, EventArgs e)
        {
            frmPersonelMesajGiden frm = new frmPersonelMesajGiden();
            this.Hide();
            frm.Show();
        }

        private void btnMesajGelen_Click(object sender, EventArgs e)
        {
            frmPersonelMesajGelen frm = new frmPersonelMesajGelen();
            this.Hide();
            frm.Show();
        }
    }
}
