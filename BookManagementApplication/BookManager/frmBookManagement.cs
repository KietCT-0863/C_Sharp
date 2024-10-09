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
    public partial class frmBookManagement : Form
    {
        public frmBookManagement()
        {
            InitializeComponent();

            BookServices bookServices = new BookServices();
            dgvBookList.DataSource = bookServices.GetAllBook();
        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            frmEditBook frmEditBook = new frmEditBook();
            frmEditBook.ShowDialog();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            frmEditBook frmEditBook = new frmEditBook();
            frmEditBook.ShowDialog();
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            frmEditBook frmEditBook = new frmEditBook();
            frmEditBook.ShowDialog();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEditBook frmEditBook = new frmEditBook();
            frmEditBook.ShowDialog();

        }
    }
}
