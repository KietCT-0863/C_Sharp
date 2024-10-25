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
using static System.Resources.ResXFileRef;

namespace BookManager
{
    public partial class frmBookDetail : Form
    {
        private BookServices _bookServices = new();
        private BookCategoryServices _bookCateServ = new();

        public Book SelectedBook { get; set; } = null;

        public frmBookDetail()
        {
            InitializeComponent();
        }
        private void frmBookDetail_Load(object sender, EventArgs e)
        {
            _bookServices.GetAllBooks();

            cboBookCategoryId.DataSource = _bookCateServ.GetAllBookCategories();
            cboBookCategoryId.DisplayMember = "BookGenreType";
            cboBookCategoryId.ValueMember = "BookCategoryId";

            if (SelectedBook != null)
            {
                txtBookId.Text = SelectedBook.BookId.ToString();
                txtTitle.Text = SelectedBook.BookName;
                txtDescription.Text = SelectedBook.Description;
                dtpPubicationDate.Value = SelectedBook.PublicationDate;
                txtQuantity.Text = SelectedBook.Quantity.ToString();
                txtPrice.Text = SelectedBook.Price.ToString();
                txtAuthor.Text = SelectedBook.Author;
                cboBookCategoryId.SelectedValue = SelectedBook.BookCategoryId;
            }
            else
                txtBookId.Text = _bookServices.GetNewBookId().ToString();
            txtBookId.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SelectedBook == null)
            {
                Book newBook = new()
                {
                    BookId = Convert.ToInt32(txtBookId.Text),
                    BookName = txtTitle.Text,
                    Description = txtDescription.Text,
                    PublicationDate = dtpPubicationDate.Value,
                    Quantity = Convert.ToInt32(txtQuantity.Text),
                    Price = Convert.ToDouble(txtPrice.Text),
                    Author = txtAuthor.Text,
                    BookCategoryId = Convert.ToInt32(cboBookCategoryId.SelectedValue)
                };
                _bookServices.AddBook(newBook);
            }
            else
            {
                Book updateBook = new()
                {
                    BookId = Convert.ToInt32(txtBookId.Text),
                    BookName = txtTitle.Text,
                    Description = txtDescription.Text,
                    PublicationDate = Convert.ToDateTime(dtpPubicationDate.Value),
                    Quantity = Convert.ToInt32(txtQuantity.Text),
                    Price = Convert.ToDouble(txtPrice.Text),
                    Author = txtAuthor.Text,
                    BookCategoryId = Convert.ToInt32(cboBookCategoryId.SelectedValue)
                };
                _bookServices.UpdateBook(updateBook);
            }
            this.Close();
        }
    }
}
