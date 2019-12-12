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
    /// <summary>
    /// Interaction logic for Smoke.xaml
    /// </summary>
    public partial class Smoke_Page : Page
    {
        public Smoke_Page()
        {
           
                InitializeComponent();
                List<Smoke> Smokes = new List<Smoke>();
                //using (FileStream fs = new FileStream("Products/snuses.xml", FileMode.Create))
                //{
                //    XmlSerializer xs = new XmlSerializer(typeof(List<Tobac>));
                //    xs.Serialize(fs, Snuses);
                //}

                using (FileStream fs = new FileStream("Products/smokes.xml", FileMode.Open))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Smoke>));
                    Smokes = (List<Smoke>)xs.Deserialize(fs);
                }
                lvSmokes.ItemsSource = Smokes;
        }

        private void Buy_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
