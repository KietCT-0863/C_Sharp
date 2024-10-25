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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BookManagerWindow
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        UserAccountServices userServices = new();
        public RegisterWindow()
        {
            InitializeComponent();
        }
        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            UserAccount? newUser = null;

            newUser = userServices.CheckUserNameExist(UserNameText.Text);

            if (newUser == null)
            {
                newUser = new() { FullName = UserNameText.Text, Email = EmailText.Text, Password = PasswordText.Text };
                userServices.AddUser(newUser);
                MessageBox.Show("Success!!!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            else
                MessageBox.Show("User name already exist!!!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        private void UserNameText_GotFocus(object sender, RoutedEventArgs e)
        {
            if (UserNameText.Text == "User Name")
            {
                UserNameText.Text = "";
                UserNameText.Foreground = Brushes.White;
            }
        }
        private void EmailText_GotFocus(object sender, RoutedEventArgs e)
        {
            if (EmailText.Text == "Email")
            {
                EmailText.Text = "";
                EmailText.Foreground = Brushes.White;
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
        private void UserNameText_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserNameText.Text))
            {
                UserNameText.Text = "User Name";
                UserNameText.Foreground = Brushes.Gray;
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
