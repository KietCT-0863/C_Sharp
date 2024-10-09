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
            LoadData();
        }

        private void LoadData()
        {
            BookServices bookServices = new BookServices();
            dgvBookList.DataSource = bookServices.GetAllBook();
        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            frmEditBook frmEditBook = new frmEditBook(new Book());
            frmEditBook.ShowDialog();
            LoadData();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRow = dgvBookList.SelectedRows[0];
                Book selectedBook = new Book()
                {
                    BookId = Convert.ToInt32(selectedRow.Cells["BookId"].Value.ToString()),
                    BookName = selectedRow.Cells["BookName"].Value.ToString(),
                    Description = selectedRow.Cells["Description"].Value.ToString(),
                    PublicationDate = Convert.ToDateTime(selectedRow.Cells["PublicationDate"].Value.ToString()),
                    Quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value.ToString()),
                    Price = Convert.ToDouble(selectedRow.Cells["price"].Value),
                    Author = selectedRow.Cells["Author"].Value.ToString(),
                    BookCategoryId = Convert.ToInt32(selectedRow.Cells["BookCategoryId"].Value.ToString())
                };

                frmEditBook frmEditBook = new frmEditBook(selectedBook);
                frmEditBook.ShowDialog();
                LoadData();
            }
            else
                MessageBox.Show("Please choise one!!!", "Warning");
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            //frmEditBook frmEditBook = new frmEditBook();
            //frmEditBook.ShowDialog();
            DataGridViewRow selectedRow = dgvBookList.SelectedRows[0];
            Book selectedBook = new Book()
            {
                BookId = Convert.ToInt32(selectedRow.Cells["BookId"].Value.ToString()),
                BookName = selectedRow.Cells["BookName"].Value.ToString(),
                Description = selectedRow.Cells["Description"].Value.ToString(),
                PublicationDate = Convert.ToDateTime(selectedRow.Cells["PublicationDate"].Value.ToString()),
                Quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value.ToString()),
                Price = Convert.ToDouble(selectedRow.Cells["price"].Value),
                Author = selectedRow.Cells["Author"].Value.ToString(),
                BookCategoryId = Convert.ToInt32(selectedRow.Cells["BookCategoryId"].Value.ToString())
            };
            BookServices bookServices = new BookServices();
            bookServices.RemoveBook(selectedBook);
            LoadData();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
