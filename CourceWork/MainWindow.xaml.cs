using CourceWork.Pages;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CourceWork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool IsMenuOpened = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Siga_btn_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Smoke_Page());
        }

        private void Snus_btn_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Snus_Page());
        }

        private void Tab_btn_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Tobac_Page());
        }

        private void Stack_Panel_MouseEnter(object sender, MouseEventArgs e)
        {
            if(!IsMenuOpened)
            {
                Stack_Panel.BeginAnimation(Rectangle.WidthProperty, null);
                DoubleAnimation animation = new DoubleAnimation();
                animation.From = 40;
                animation.To = 150;
                animation.Duration = TimeSpan.FromSeconds(0.1);
                animation.Completed += Animation_Completed;
                Stack_Panel.BeginAnimation(Rectangle.WidthProperty, animation);
            }
           

        }

        private void Animation_Completed(object sender, EventArgs e)
        {
            IsMenuOpened = true;
        }

        private void Stack_Panel_MouseLeave(object sender, MouseEventArgs e)
        {
            if (IsMenuOpened)
            {
                Stack_Panel.BeginAnimation(Rectangle.WidthProperty, null);
                DoubleAnimation animation = new DoubleAnimation();
                animation.From = 150;
                animation.To = 40;
                animation.Duration = TimeSpan.FromSeconds(0.1);
                animation.Completed += Animation_Completed1;
                Stack_Panel.BeginAnimation(Rectangle.WidthProperty, animation);
            }
        }

        private void Animation_Completed1(object sender, EventArgs e)
        {
            IsMenuOpened = false;

        }

        private void Log_btn_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();

            login.Show();
        }

        private void Buy_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
