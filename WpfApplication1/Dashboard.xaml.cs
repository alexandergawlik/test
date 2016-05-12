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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        private string user;
        private string password;
        public Dashboard(string usr, string pswd)
        {
            user = usr;
            password = pswd;
            InitializeComponent();
        }

        private void menu_wyjscie_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result =  MessageBox.Show("Czy chcesz zakończyć działanie systemu?", "Pytanie", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        
        private void menuwybierzZakladke_Click(object sender, RoutedEventArgs e)
        {
            MenuItem obiekt = sender as MenuItem;
            
        }
    }
}
