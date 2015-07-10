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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace Baza_Pacjentow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Pacjent pac1 = new Pacjent();
            List <Pacjent> lista_pac = new List<Pacjent>();
            lista_pac.Add(pac1);
            pac1 = new Pacjent() { Nazwisko = "Chopin", Imie= "Fryderyk", Adres= "Paryz 123/18", Nr_tel= 33333333 , Stawka= 10 };
            lista_pac.Add(pac1);
            using (XmlWriter xw = XmlWriter.Create("newxml1.xml"))
            {
                xw.WriteStartDocument();
                xw.WriteStartElement("lista_pac");
                foreach (Pacjent pacjent in lista_pac)
                {
                    xw.WriteStartElement("pacjent");
                    xw.WriteElementString("nazwisko", pacjent.Nazwisko);
                    xw.WriteElementString("imie", pacjent.Imie);
                    xw.WriteElementString("adres", pacjent.Adres);
                    xw.WriteElementString("telefon", pacjent.Nr_tel.ToString());
                    xw.WriteElementString("stawka", pacjent.Stawka.ToString());
                    xw.WriteEndElement();
                }
                xw.WriteEndElement();
                xw.WriteEndDocument();
            }
        }
    }
}
