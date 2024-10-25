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
            LoadData();
        }
        private void LoadData()
        {
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = _bookServices.GetAllBooks();
        }
        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string nameSearch = txtBookNameSearch.Text;
            string descriptionSearch = txtBookDescriptionSearch.Text;
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = _bookServices.SearchBook(nameSearch, descriptionSearch, _bookServices.GetAllBooks());
        }
        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                _seletedBook = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
            }
        }
        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            frmBookDetail frmBookDetail = new frmBookDetail();
            frmBookDetail.ShowDialog();
        }
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (_seletedBook != null)
            {
                frmBookDetail frmBookDetail = new frmBookDetail();
                frmBookDetail.SelectedBook = _seletedBook;
                frmBookDetail.ShowDialog();
                LoadData();
                _seletedBook = null;
            }
            else
                MessageBox.Show("Please SELECT a Book!!!", "Select one Book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (_seletedBook != null)
            {
                Book selectedBook = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
                _bookServices.RemoveBook(selectedBook);
                LoadData();
                _seletedBook = null;
            }
            else MessageBox.Show("Please SELECT a Book!!!", "Select one Book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
