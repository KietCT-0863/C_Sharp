using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class frmUserAccountManagement : Form
    {
        public frmUserAccountManagement()
        {
            InitializeComponent();
            UserAccountServices userServ = new UserAccountServices();
            dgvUserAccount.DataSource = userServ.GetAllUserAccount();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditUser frmEditUser = new frmEditUser();
            frmEditUser.ShowDialog();
            this.Show();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditUser frmEditUser = new frmEditUser();
            frmEditUser.ShowDialog();
            this.Show();
        }

        private void btnRemoveAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditUser frmEditUser = new frmEditUser();
            frmEditUser.ShowDialog();
            this.Show();
        }
    }
}
