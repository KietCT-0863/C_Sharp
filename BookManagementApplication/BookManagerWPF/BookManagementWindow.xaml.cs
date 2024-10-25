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
    /// Interaction logic for BookManagementWindow.xaml
    /// </summary>
    public partial class BookManagementWindow : Window
    {
        BookServices _bookServices = new();
        Book _selectedBook = null;

        public BookManagementWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BookListDataGrid.ItemsSource = null;
            BookListDataGrid.ItemsSource = _bookServices.BookList;
        }

        private void CreateBookButton_Click(object sender, RoutedEventArgs e)
        {
            
            BookDetailWindow bookDetailWindow = new();
            bookDetailWindow.ShowDialog();
            Window_Loaded(sender, e);
        }
        private void DeleteBookButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            int result = Convert.ToInt32(MessageBox.Show("Do you realy want to go BACK?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question));
            if (result == 6)
            {
                this.Close();
            }
        }
        private void SearchBookButton_Click(object sender, RoutedEventArgs e)
        {
            string titleSearch = TitleText.Text;
            string descriptionSearch = DescriptionText.Text;
            List<Book> listBookFound = _bookServices.SearchBook(titleSearch, descriptionSearch, _bookServices.BookList);

            if (listBookFound.Count < 1)
            {
                int result = Convert.ToInt32(MessageBox.Show("A book doesn't exist!\nDo you want to create one?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Information));
                if (result == 6)
                {
                    BookDetailWindow bookDetailWindow = new BookDetailWindow();
                    bookDetailWindow.ShowDialog();
                }
                else
                {
                    RefreshButton_Click(sender, e);
                }
            }
            else
            {
                BookListDataGrid.ItemsSource = null;
                BookListDataGrid.ItemsSource = listBookFound;
            }
        }
        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            TitleText.Text = "";
            DescriptionText.Text = "";
            Window_Loaded(sender, e);
        }
        private void UpdateBookButton_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            if (_selectedBook != null)
            {
                BookDetailWindow bookDetailWindow = new();
                bookDetailWindow.SelectedBook = _selectedBook;
                bookDetailWindow.ShowDialog();
            }
            else
                MessageBox.Show("You need to choice ONE!!!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        private void BookListDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BookListDataGrid.SelectedItems.Count > 0)
            {
                _selectedBook = (Book)BookListDataGrid.SelectedItems[0];
            }
        }
    }
}
