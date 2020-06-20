using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
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
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            switch (index)
            {
                case 0:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UserControls());
                    break;

                case 1:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UserControlFood());
                    break;

                case 2:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UserControlOrder());
                    break;

                case 3:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UserControlCashs());
                    break;

                default:
                    break;

            }
        }

        private void MoveCursorMenu(int index)
        {
            
            TrainsitioningContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (100 + (60 * index)), 0, 0);
        }

        private void ListViewItem_Selected()
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Baza bazunia = new Baza();
            bazunia.usun();
        }

        private void ButtonClickFacebook(object sender, RoutedEventArgs e)
        {
            Process.Start("http://www.facebook.com");
        }
        private void ButtonClickGitHub(object sender, RoutedEventArgs e)
        {
            Process.Start("http://www.github.com");
        }

    }
}
