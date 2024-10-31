using Repositories.Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BookManagerWindow
{
    /// <summary>
    /// Interaction logic for BookDetailWindow.xaml
    /// </summary>
    public partial class BookDetailWindow : Window
    {
        // NOTE CHECK INPUT VALIDATION

        BookServices _bookService = new();
        BookCategoryServices _bookCategoryService = new();

        public Book? SelectedBook { get; set; }

        public BookDetailWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CategoryComboBox.ItemsSource = _bookCategoryService.GetAllBookCategories();
            CategoryComboBox.DisplayMemberPath = "BookGenreType";
            CategoryComboBox.SelectedValue = "BookCategoryId";

            if (SelectedBook != null)
            {
                HeaderLabel.Content = "Update book";
                BookIdText.Text = SelectedBook.BookId.ToString();
                TitleText.Text = SelectedBook.BookName;
                DescriptionText.Text = SelectedBook.Description;
                PublicationDatePicker.Text = SelectedBook.PublicationDate.ToString();
                QuantityText.Text = SelectedBook.Quantity.ToString();
                PriceText.Text = SelectedBook.Price.ToString();
                AuthorText.Text = SelectedBook.Author;
                CategoryComboBox.SelectedValue = SelectedBook.BookCategoryId;
            }
            else
            {
                HeaderLabel.Content = "Create book";
                BookIdText.Text = _bookService.GetNewBookId().ToString();
            }

            BookIdText.IsEnabled = false;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedBook == null)
            {
                Book newBook = new();
                newBook.BookId = Convert.ToInt32(BookIdText.Text);
                newBook.BookName = TitleText.Text;
                newBook.Description = DescriptionText.Text;
                newBook.PublicationDate = DateTime.Parse(PublicationDatePicker.Text);
                newBook.Quantity = Convert.ToInt32(QuantityText.Text);
                newBook.Price = Convert.ToDouble(PriceText.Text);
                newBook.Author = AuthorText.Text;
                newBook.BookCategoryId = Convert.ToInt32(CategoryComboBox.SelectedValue.ToString());
                _bookService.AddBook(newBook);
                MessageBox.Show("Create book Success!!!", "Information", MessageBoxButton.OK);
                this.Close();
            }
            else
            {
                Book updateBook = new();
                updateBook.BookId = Convert.ToInt32(BookIdText.Text);
                updateBook.BookName = TitleText.Text;
                updateBook.Description = DescriptionText.Text;
                updateBook.PublicationDate = DateTime.Parse(PublicationDatePicker.Text);
                updateBook.Quantity = Convert.ToInt32(QuantityText.Text);
                updateBook.Price = Convert.ToDouble(PriceText.Text);
                updateBook.Author = AuthorText.Text;
                updateBook.BookCategoryId = Convert.ToInt32(CategoryComboBox.SelectedValue.ToString());
                _bookService.UpdateBook(updateBook);
                MessageBox.Show("Update book Success!!!", "Information", MessageBoxButton.OK);
                this.Close();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
