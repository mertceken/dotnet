using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _190126_bireysel_proje.Forms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        DonateDBEntities dn = new DonateDBEntities();
        private void button3_Click(object sender, EventArgs e)
        {
            tblDonate dnt = new tblDonate();

            dnt.DonateName = txtName.Text;
            dnt.DonateOrganization = txtOrg.Text;
            dnt.DonateType = cmbDonation.Text;
            dnt.MonthlyDonations = Convert.ToInt32(txtMonthly.Text);
            dnt.Address = txtAddress.Text;
            dn.tblDonate.Add(dnt);
            dn.SaveChanges();
        }
    }
}
