using BookManagerWindow;
using Repositories.Models;
using Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookManagerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserAccountServices _accountServices = new();
        UserAccount? _loginAccount = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            EmailText.Text = "Email";
            EmailText.Foreground = Brushes.Gray;
            PasswordText.Text = "Password";
            PasswordText.Foreground = Brushes.Gray;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (!CheckWatermark())
            {
                string email = EmailText.Text.Trim();
                string password = PasswordText.Text;

                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("User Name and Password cant be Empty!!!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                _loginAccount = _accountServices.LoginAccount(EmailText.Text, PasswordText.Text);

                if (_loginAccount == null)
                {
                    MessageBox.Show("Invalid User name or Password!!!", "Warning credentials", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (_loginAccount.Role == 3)
                {
                    MessageBox.Show("You have no permission", "Wrong permission", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                this.Hide();
                BookManagementWindow bookManagementWindow = new();
                bookManagementWindow.LoginUserAccount = _loginAccount;
                bookManagementWindow.ShowDialog();
                Window_Loaded(sender, e);
                this.Show();
            }
        }

        private bool CheckWatermark()
        {
            if (EmailText.Foreground == Brushes.Gray || PasswordText.Foreground == Brushes.Gray)
            {
                MessageBox.Show("User Name and Password cant be Empty!!!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return true;
            }
            return false;
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new();
            registerWindow.ShowDialog();
        }

        private void EmailText_GotFocus(object sender, RoutedEventArgs e)
        {
            if (EmailText.Text == "Email")
            {
                EmailText.Text = "";
                EmailText.Foreground = Brushes.White;
            }
        }

        private void EmailText_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmailText.Text))
            {
                EmailText.Text = "Email";
                EmailText.Foreground = Brushes.Gray;
            }
        }

        private void PasswordText_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordText.Text == "Password")
            {
                PasswordText.Text = "";
                PasswordText.Foreground = Brushes.White;
            }
        }

        private void PasswordText_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordText.Text))
            {
                PasswordText.Text = "Password";
                PasswordText.Foreground = Brushes.Gray;
            }
        }
    }
}