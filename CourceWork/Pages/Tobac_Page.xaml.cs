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
    /// Interaction logic for Tobac_Page.xaml
    /// </summary>
    public partial class Tobac_Page : Page
    {
        public Tobac_Page()
        {
            InitializeComponent();
            List<Tobac> Tobacos = new List<Tobac>();
            //using (FileStream fs = new FileStream("Products/tobacs.xml", FileMode.Create))
            //{
            //    XmlSerializer xs = new XmlSerializer(typeof(List<Tobac>));
            //    xs.Serialize(fs,Tobacos);
            //}

            using (FileStream fs=new FileStream("Products/tobacs.xml", FileMode.Open))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Tobac>));
                Tobacos = (List<Tobac>)xs.Deserialize(fs);
            }

            lvTobacos.ItemsSource = Tobacos;
            
        }

        private void Buy_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
