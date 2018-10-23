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
    public partial class frmKasa : Form
    {
        public frmKasa()
        {
            InitializeComponent();
        }

        private void btnKasaOdeme_Click(object sender, EventArgs e)
        {
            frmKasaOdeme frm = new frmKasaOdeme();
            this.Hide();
            frm.Show();
        }

        private void btnKasaListe_Click(object sender, EventArgs e)
        {
            frmKasaListe frm = new frmKasaListe();
            this.Hide();
            frm.Show();
        }

        private void frmKasa_Load(object sender, EventArgs e)
        {

        }
    }
}
