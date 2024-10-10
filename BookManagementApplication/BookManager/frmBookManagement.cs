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
        private BookServices _bookServices = new();
        private Book _seletedBook = null;

        public frmBookManagement()
        {
            InitializeComponent();
        }

        private void frmBookManagement_Load(object sender, EventArgs e)
        {
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = _bookServices.GetAllBooks();
        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            frmBookDetail frmBookDetail = new frmBookDetail();
            frmBookDetail.ShowDialog();
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                _seletedBook = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (_seletedBook != null)
            {
                frmBookDetail frmBookDetail = new frmBookDetail();
                frmBookDetail.SelectedBook = _seletedBook;
                frmBookDetail.ShowDialog();
                _seletedBook = null;
            }
            else
                MessageBox.Show("Please SELECT a Book!!!", "Select one Book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            //Book selectedBook = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
            //_bookServices.RemoveBook(selectedBook);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
