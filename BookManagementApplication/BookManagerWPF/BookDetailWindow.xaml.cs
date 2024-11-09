using Repositories.Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
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

        public Book? SelectedBook { get; set; }

        public BookDetailWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CategoryComboBox.ItemsSource = _bookCategoryService.GetAllBookCategories();
            CategoryComboBox.DisplayMemberPath = "BookGenreType";
            CategoryComboBox.SelectedValuePath = "BookCategoryId";

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

        private bool IsNullOrWhiteSpace(string? stringCheck)
        {
            if (string.IsNullOrWhiteSpace(stringCheck))
            {
                return true;
            }
            return false;
        }

        private bool IsValidAlphabetLength(string stringCheck, int minLength)
        {
            if (stringCheck.Length >= minLength)
            {
                return true;
            }

            return false;
        }

        private void PrintNullError(string errorName)
        {
            MessageBox.Show(errorName + " cant be Empty", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void PrintLengthError(string errorNames, int number)
        {
            MessageBox.Show(errorNames + " must have at least " + number + " characters", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private bool IsValidAlphabet(string stringCheck, int length, string checkName)
        {
            if (IsNullOrWhiteSpace(stringCheck) ||
                !IsValidAlphabetLength(stringCheck, length))
            {
                if (IsNullOrWhiteSpace(stringCheck))
                {
                    PrintNullError(checkName);
                }
                else
                {
                    PrintLengthError(checkName, length);
                }

                return false;
            }

            return true;
        }

        private bool IsIntNumber(string? stringCheck)
        {
            if (int.TryParse(stringCheck, out int value1))
            {
                return true;
            }
            return false;
        }

        private bool IsDoubleNumber(string? stringCheck)
        {
            if (double.TryParse(stringCheck, out double value2))
            {
                return true;
            }

            return false;
        }

        private bool IsValidNumSize(string? stringCheck, int maxNumber)
        {
            if (0 < Convert.ToDouble(stringCheck) &&
                Convert.ToInt32(stringCheck) < maxNumber)
            {
                return true;
            }
            return false;
        }

        private bool IsValidNumSize(string? stringCheck, double maxNumber)
        {
            if (0 <= Convert.ToDouble(stringCheck) &&
                Convert.ToDouble(stringCheck) <= maxNumber)
            {
                return true;
            }
            return false;
        }

        private void PrintNumberError(string errorName, string numStyle)
        {
            MessageBox.Show($"{errorName} must be {numStyle}", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void PrintNumberSizeError(string errorName, int maxNumber)
        {
            MessageBox.Show($"{errorName} must greater than 0 and lower than {maxNumber} \n( 0 <= {errorName} <= {maxNumber} )", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void PrintNumberSizeError(string errorName, double maxNumber)
        {
            MessageBox.Show($"{errorName} must greater than 0 and lower than {maxNumber} \n( 0 <= {errorName} <= {maxNumber} )", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private bool IsValidNumber(string? intCheck, double maxNumber, string checkName)
        {
            if (IsNullOrWhiteSpace(intCheck) ||
                !IsDoubleNumber(intCheck) ||
                !IsValidNumSize(intCheck, maxNumber))
            {
                if (IsNullOrWhiteSpace(intCheck))
                {
                    PrintNullError(checkName);
                }
                else if (!IsDoubleNumber(intCheck))
                {
                    PrintNumberError(checkName, "Decimal number");
                }
                else
                {
                    PrintNumberSizeError(checkName, maxNumber);
                }
                return false;
            }
            return true;
        }

        private bool IsValidNumber(string? intCheck, int maxNumber, string checkName)
        {
            if (IsNullOrWhiteSpace(intCheck) ||
                !IsIntNumber(intCheck) ||
                !IsValidNumSize(intCheck, maxNumber))
            {
                if (IsNullOrWhiteSpace(intCheck))
                {
                    PrintNullError(checkName);
                }
                else if (!IsIntNumber(intCheck))
                {
                    PrintNumberError(checkName, "Natural number");
                }
                else
                {
                    PrintNumberSizeError(checkName, maxNumber);
                }
                return false;
            }
            return true;
        }

        private void PrintDateTimeError()
        {
            MessageBox.Show("Date time must follow format[ DD/MM/YYYY", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private bool IsDateTime(string dateTimeCheck)
        {
            if (!DateTime.TryParse(dateTimeCheck, out DateTime result))
            {
                PrintDateTimeError();
                return false;
            }
            return true;
        }

        private void PrintCategoryError()
        {
            MessageBox.Show("Please choice category", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private bool IsValidCategory(object bookCategory)
        {
            if (bookCategory == null)
            {
                PrintCategoryError();
                return false;
            }
            return true;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (!IsValidAlphabet(TitleText.Text, 5, "Title") ||
                !IsValidAlphabet(DescriptionText.Text, 10, "Description") ||
                !IsDateTime(PublicationDatePicker.Text) ||
                !IsValidNumber(QuantityText.Text, 500, "Quantity") ||
                !IsValidNumber(PriceText.Text, 10000.00, "Price") ||
                !IsValidAlphabet(AuthorText.Text, 5, "Author") ||
                !IsValidCategory(CategoryComboBox.SelectedValue))
            {
                return;
            }

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
                newBook.BookCategoryId = Convert.ToInt32(CategoryComboBox.SelectedValue);
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
                updateBook.BookCategoryId = Convert.ToInt32(CategoryComboBox.SelectedValue);
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
