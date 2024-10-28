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
        BookServices _bookService = new();
        BookCategoryServices _bookCategoryService = new();

        public Book? SelectedBook { get; set; } = null;

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
                MessageBox.Show("Add new Book", "Information", MessageBoxButton.OK);
                this.Close();
            }
            if (SelectedBook != null)
            {
                //bookService.UpdateBook(SelectedBook);
                MessageBox.Show("Update Book", "Information", MessageBoxButton.OK);
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
