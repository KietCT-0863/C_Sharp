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
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Check Input Validation
            // string.IsNullOrWhiteSpace dùng để kiểm tra xem chuỗi string đầu vào có null hay chứa only 1 khoảng trắng
            if (!string.IsNullOrWhiteSpace(txtNewUserName.Text) && !string.IsNullOrWhiteSpace(txtNewEmail.Text) && !string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                UserAccountServices userAccountServices = new UserAccountServices();
                userAccountServices.AddUser(new() { FullName = txtNewUserName.Text, Email = txtNewEmail.Text, Password = txtNewPassword.Text, Role = 3 });
                this.Close();

                //if (cboxOptionalChoice.SelectedItem == "Gawr Gura")
                //{
                //    this.Close();
                //    Form frmGura = new Form();
                //    frmGura.ShowDialog();
                //}
                //else if (cboxOptionalChoice.SelectedItem == "Ninomae Ina'nis")
                //{
                //    this.Close();
                //    Form frmGura = new Form();
                //    frmGura.ShowDialog();
                //}
                //else if (cboxOptionalChoice.SelectedItem == "Watson Amelia")
                //{
                //    this.Close();
                //    Form frmGura = new Form();
                //    frmGura.ShowDialog();
                //}
                //else if (cboxOptionalChoice.SelectedItem == "Takanashi Kiara")
                //{
                //    this.Close();
                //    Form frmGura = new Form();
                //    frmGura.ShowDialog();
                //}
                //else if (cboxOptionalChoice.SelectedItem == "Mori Calliope")
                //{
                //    this.Close();
                //    Form frmGura = new Form();
                //    frmGura.ShowDialog();
                //}
                //else this.Close();
            }
            else
            {
                MessageBox.Show("Input cannot be Empty", "Warning!!!");
            }
        }
    }
}
