using Microsoft.VisualBasic.ApplicationServices;
using Repositories;
using Repositories.Models;
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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();

            cboxOptionalChoice.Text = "Optional Choice";
            cboxOptionalChoice.Items.Add("Gawr Gura");
            cboxOptionalChoice.Items.Add("Ninomae Ina'nis");
            cboxOptionalChoice.Items.Add("Watson Amelia");
            cboxOptionalChoice.Items.Add("Takanashi Kiara");
            cboxOptionalChoice.Items.Add("Mori Calliope");

            //UserAccount newUser = new() { FullName = txtNewUserName.Text, Email = txtNewEmail.Text, Password = txtNewPassword.Text, Role = 3 };
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UserAccountServices userAccountServices = new UserAccountServices();
            userAccountServices.AddUser( new() {FullName = txtNewUserName.Text, Email = txtNewEmail.Text, Password = txtNewPassword.Text, Role = 3 } );

            if (cboxOptionalChoice.SelectedItem == "Gawr Gura")
            {
                this.Hide();
                Form frmGura = new Form();
                frmGura.ShowDialog();
                this.Close();
            }

            this.Hide();
        }
    }
}
