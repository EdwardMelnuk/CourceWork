using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.ComponentModel.DataAnnotations;

namespace CourceWork
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        private static string file_name = "logins.txt";

        public Registration() { InitializeComponent(); }
        static Registration() { if (!File.Exists(file_name)) File.Create(file_name); }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            string login = NewLogin.Text, address = Email.Text, password = Password.Password, confirm_password = ConfirmPassword.Password;

            if (Regex.Matches(login, @"(\w+)").Count != 1)
            {
                MessageBox.Show("Incorrect login!");
                return;
            }

            if (!(address != null && new EmailAddressAttribute().IsValid(address)))
            {
                MessageBox.Show("Incorrect email!");
                return;
            }

            if (Regex.Matches(password, @"(\s+)").Count != 0)
            {
                MessageBox.Show("Incorrect password!");
                return;
            }

            if (password != confirm_password)
            {
                MessageBox.Show("Password are different!");
                return;
            }

            SaveAccount(login, password);
            Close();
        }

        private void AlreadyHave_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Login login = new Login();

            login.Show();

            Close();
        }

        private void SaveAccount(string login, string password)
        {
            using (StreamWriter sw = new StreamWriter(file_name, true))
                sw.WriteLine(login + " : " + password);
        }
    }
}
