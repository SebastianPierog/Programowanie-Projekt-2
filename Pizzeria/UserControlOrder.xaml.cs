using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
    /// Logika interakcji dla klasy UserControlOrder.xaml
    /// </summary>
    public partial class UserControlOrder
    {
        public UserControlOrder()
        {
            InitializeComponent();
        }

        private void pokazywacz_Loaded(object sender, RoutedEventArgs e)
        {
            Baza bazunia = new Baza();

            string[] zamowienie = new string[2];

            zamowienie = bazunia.pobierz("Margheritta");

            //

            StringBuilder pizza1 = new StringBuilder();

            foreach (var item in zamowienie)
            {
                pizza1.Append(item);
            }

            Label labelka = new Label();
            labelka.Content = pizza1.ToString();
            pokazywacz.Items.Add(labelka);

        }
        private void pokazywacz2_Loaded(object sender, RoutedEventArgs e)
        {
            Baza bazunia1 = new Baza();

            string[] zamowienie1 = new string[2];

            zamowienie1 = bazunia1.pobierz("Capricciosa");

            //

            StringBuilder pizza2 = new StringBuilder();

            foreach (var item in zamowienie1)
            {
                pizza2.Append(item);
            }

            Label labelka = new Label();
            labelka.Content = pizza2.ToString();
            pokazywacz.Items.Add(labelka);

        }
        private void pokazywacz3_Loaded(object sender, RoutedEventArgs e)
        {
            Baza bazunia2 = new Baza();

            string[] zamowienie2 = new string[2];

            zamowienie2 = bazunia2.pobierz("Wiejska");

            //

            StringBuilder pizza3 = new StringBuilder();

            foreach (var item in zamowienie2)
            {
                pizza3.Append(item);
            }

            Label labelka = new Label();
            labelka.Content = pizza3.ToString();
            pokazywacz.Items.Add(labelka);

        }
    }
}
