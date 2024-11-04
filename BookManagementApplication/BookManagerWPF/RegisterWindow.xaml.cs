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
        UserAccountServices _userServices = new();

        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            UserAccount? newUser = new();

            if (checkEmptyInput(UserNameText.Text) || checkEmptyInput(EmailText.Text) || checkEmptyInput(PasswordText.Text))
            {
                MessageBox.Show("Input cant be empty!!!");
                return;
            }

            if (_userServices.CheckUserExist(EmailText.Text)!=null)
            {
                MessageBox.Show("User name already exist!!!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            newUser.FullName = UserNameText.Text;
            newUser.Email = EmailText.Text;
            newUser.Password = PasswordText.Text;
            newUser.Role = 3;

            _userServices.AddUser(newUser);
            MessageBox.Show("Success!!!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }

        private bool checkEmptyInput(string inputCheck)
        {
            if (string.IsNullOrWhiteSpace(inputCheck))
            {
                return true;
            }
            return false;
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
