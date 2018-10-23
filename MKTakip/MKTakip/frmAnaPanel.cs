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
    public partial class frmAnaPanel : Form
    {
        public frmAnaPanel()
        {
            InitializeComponent();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            frmMusteri frm = new frmMusteri();
            this.Hide();
            frm.Show();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            frmUrun frm = new frmUrun();
            this.Hide();
            frm.Show();
        }

        private void btnProje_Click(object sender, EventArgs e)
        {
            frmProje frm = new frmProje();
            this.Hide();
            frm.Show();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            frmKasa frm = new frmKasa();
            this.Hide();
            frm.Show();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            frmPersonel frm = new frmPersonel();
            this.Hide();
            frm.Show();
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            frmHakkimizda frm = new frmHakkimizda();
            this.Hide();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAnaPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
