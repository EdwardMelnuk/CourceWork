using CourceWork.Classes;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace CourceWork.Pages
{
    /// <summary>7
    /// Interaction logic for Snus_Page.xaml
    /// </summary>
    public partial class Snus_Page : Page
    {
        public Snus_Page()
        {
            InitializeComponent();
            List<Snus> Snuses = new List<Snus>();
            //using (FileStream fs = new FileStream("Products/snuses.xml", FileMode.Create))
            //{
            //    XmlSerializer xs = new XmlSerializer(typeof(List<Tobac>));
            //    xs.Serialize(fs, Snuses);
            //}

            using (FileStream fs = new FileStream("Products/snuses.xml", FileMode.Open))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Snus>));
                Snuses = (List<Snus>)xs.Deserialize(fs);
            }
            lvSnuses.ItemsSource = Snuses;
        }

        private void Buy_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
