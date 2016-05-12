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
using System.Data.SqlClient;
using System.Data;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Czy chcesz zakończyć działanie systemu?", "Pytanie", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string ConnString = "Data Source=DELL;Initial Catalog=Wypozyczalnia;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection conn = new SqlConnection(ConnString);

            //conn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT Count(*) From Pracownicy where Nazwisko='" + txt_user.Text + "'and Haslo='" + txt_password.Password + "'", conn);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("poprawne haslo");
            }
            else
            {
                MessageBox.Show("Wprowadzono błędne hasło, spróbuj ponownie", "Błąd", MessageBoxButton.OK, MessageBoxImage.Warning);
                txt_password.Password = "";
                txt_user.Text = "";
            }


            label1.Content = conn.State.ToString();


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            

        }
    }
}
