using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

namespace Pizzeria
{
    /// <summary>
    /// Logika interakcji dla klasy UserControlFood.xaml
    /// </summary>
    public partial class UserControlFood
    {

        public UserControlFood()
        {
            InitializeComponent();
        }

        private void ButtonAddCapricciosa(object sender, RoutedEventArgs e)
        {
            Baza bazunia = new Baza();
            bazunia.dodaj("Capricciosa", 25);
        }  
            private void ButtonAddMargheritta(object sender, RoutedEventArgs e)
        {
            Baza bazunia1 = new Baza();
            bazunia1.dodaj("Margheritta", 27);
        }
             private void ButtonAddWiejska(object sender, RoutedEventArgs e)
        {
            Baza bazunia2 = new Baza();
            bazunia2.dodaj("Wiejska", 29);
        }
    }
}
