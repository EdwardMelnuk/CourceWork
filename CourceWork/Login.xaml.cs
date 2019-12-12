﻿using System;
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

namespace CourceWork
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private static string file_name = "logins.txt";

        public Login() { InitializeComponent(); }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = Login_.Text, password = Password.Password;

            if (Regex.Matches(login, @"(\w+)").Count != 1)
            {
                MessageBox.Show("Incorrect login!");
                return;
            }
            else if (Regex.Matches(password, @"(\s+)").Count != 0)
            {
                MessageBox.Show("Incorrect password!");
                return;
            }
            else if (!AccountExist(login, password))
            {
                MessageBox.Show("Wrong login or password!");
                return;
            }

            MessageBox.Show("Welcome!");

            Close();
        }

        private void Join_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Registration registration = new Registration();

            registration.Show();
            Close();
        }

        private bool AccountExist(string login, string password)
        {
            List<string> content = new List<string>(File.ReadAllLines(file_name));
            List<string> logins = new List<string>(), passwords = new List<string>();

            if (content.Count != 0)
            {

                for (int i = 0; i < content.Count; i++)
                {
                    logins.Add(content[i].Substring(0, content[i].IndexOf(' ')));
                    passwords.Add(content[i].Substring(content[i].LastIndexOf(' ') + 1));
                }

                int index = logins.FindIndex(x => x == login);

                if (index == -1) return false;
                else if (passwords[index] != password) return false;

                return true;
            }
            else return false;
        }

        private void Password_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
