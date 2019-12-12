using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Xml.Serialization;

namespace CourceWork.Classes
{
    [Serializable]
    public class Tobac
    {
        public Tobac() { }

        public Tobac(string name, float price, string imagePath)
        {
            this.Name = name;

            this.Price = price;

            this.ImagePath = imagePath;

        }
        string imageName;

        public string Name { get; set; }

        public float Price { get; set; }

        public string ImagePath {
            get {
                return imageName;
            }
            set {
                String path = Path.Combine(
                Environment.CurrentDirectory,
                ConfigurationManager.AppSettings["TobacImages"].ToString());

                string pathImage = Path.Combine(path, value);
                this.Image = new BitmapImage(new Uri(pathImage, UriKind.Absolute));
                this.imageName = value;
            }
        }

        [XmlIgnore]
        public BitmapImage Image { get; set; }
    }
}
