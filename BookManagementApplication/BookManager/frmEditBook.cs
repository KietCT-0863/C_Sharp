using Microsoft.EntityFrameworkCore.Diagnostics;
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
    public partial class frmEditBook : Form
    {
        private bool flagCheckAddOrUpdate = false;
        private BookServices bookServices = new BookServices();

        public frmEditBook(Book selectedBook)
        {
            InitializeComponent();
            LoadData(selectedBook);
            CheckAddOrUpdate(selectedBook);
        }

        private void LoadData(Book loadBook)
        {
            txtId.Text = loadBook.BookId.ToString();
            txtTitle.Text = loadBook.BookName;
            txtDescription.Text = loadBook.Description;
            txtPulicationDate.Text = loadBook.PublicationDate.ToString();
            txtQuantity.Text = loadBook.Quantity.ToString();
            txtPrice.Text = loadBook.Price.ToString();
            txtAuthor.Text = loadBook.Author;
            txtCategoryId.Text = loadBook.BookCategoryId.ToString();
        }

        private void CheckAddOrUpdate(Book checkBook)
        {
            txtId.Enabled = false;
            if (checkBook.BookId == 0)
            {
                flagCheckAddOrUpdate = true;
                txtId.Text = bookServices.GetBookPrimaryKey().ToString();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (flagCheckAddOrUpdate == true)
            {
                txtId.ReadOnly = true;
                Book newBook = new Book()
                {
                    BookName = txtTitle.Text,
                    Description = txtDescription.Text,
                    PublicationDate = Convert.ToDateTime(txtPulicationDate.Text),
                    Quantity = Convert.ToInt32(txtQuantity.Text),
                    Price = Convert.ToDouble(txtPrice.Text),
                    Author = txtAuthor.Text,
                    BookCategoryId = Convert.ToInt32(txtCategoryId.Text)
                };
                bookServices.AddBook(newBook);
            }
            else
            {
                Book updateBook = new Book()
                {
                    BookId = Convert.ToInt32(txtId.Text),
                    BookName = txtTitle.Text,
                    Description = txtDescription.Text,
                    PublicationDate = Convert.ToDateTime(txtPulicationDate.Text),
                    Quantity = Convert.ToInt32(txtQuantity.Text),
                    Price = Convert.ToDouble(txtPrice.Text),
                    Author = txtAuthor.Text,
                    BookCategoryId = Convert.ToInt32(txtCategoryId.Text)
                };
                bookServices.UpdateBook(updateBook);
            }
            this.Close();
        }
    }
}
