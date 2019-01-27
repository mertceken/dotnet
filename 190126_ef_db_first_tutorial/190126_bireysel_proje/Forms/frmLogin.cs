using _190126_bireysel_proje.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _190126_bireysel_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text=="admin" && txtPassword.Text=="1234" )
            {
            
                frmDashboard dsh = new frmDashboard();
                dsh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login is failed. Please Try Again..");
            }
            
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }
    }
}
