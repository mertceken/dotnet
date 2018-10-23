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
    public partial class frmProje : Form
    {
        public frmProje()
        {
            InitializeComponent();
        }


        private void btnProjeEkle_Click(object sender, EventArgs e)
        {
            frmProjeEkle frm = new frmProjeEkle();
            this.Hide();
            frm.Show();
        }

        private void btnTablo_Click(object sender, EventArgs e)
        {
            frmProjeListe frm = new frmProjeListe();
            this.Hide();
        }
    }
}
