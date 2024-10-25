using BookManagerWindow;
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

        public MainWindow()
        {
            InitializeComponent();
        }
        private void UserNameText_GotFocus(object sender, RoutedEventArgs e)
        {
            if (UserNameText.Text == "User Name")
            {
                UserNameText.Text = "";
                UserNameText.Foreground = Brushes.White;
            }
        }
        private void UserNameText_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserNameText.Text))
            {
                UserNameText.Text = "User Name";
                UserNameText.Foreground = Brushes.Gray;
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
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (_accountServices.LoginAccount(UserNameText.Text, PasswordText.Text) != null)
            {
                this.Hide();
                BookManagementWindow bookManagementWindow = new();
                bookManagementWindow.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong User name or Password!!!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new();
            registerWindow.ShowDialog();
        }
    }
}