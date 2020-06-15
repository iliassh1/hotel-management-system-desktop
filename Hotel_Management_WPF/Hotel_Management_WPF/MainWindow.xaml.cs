/* Dieser Code Anteil wurde geschrieben von:
Name: Hilmi
Vorname : Iliass
*/

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
using System.Data.SQLite;


namespace Hotel_Management_WPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    /// 
    public static class MyGlobals
    {
        public static string B_Suche = "";
        public static string kundenId ;
        public static int Valcheck = 0;

    }
    public partial class MainWindow : Window
    {
        string dbConnectionString = @"Data Source=Hotel_DB.db; Version= 3;";

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            // Verbindung mit dem DB öffenen

            try
            {
                sqliteCon.Open();
                string Query = "select * from Benutzer where Benutzer_login = '" + this.txt_log.Text + "' and Passwort = '" + this.txt_password.Password + "' ";
                SQLiteCommand CreateCommand = new SQLiteCommand(Query, sqliteCon);
                CreateCommand.ExecuteNonQuery();
                SQLiteDataReader reader = CreateCommand.ExecuteReader();
                int count = 0;

                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    NavPage win2 = new NavPage();
                    this.Content = win2;
                }
                if (count > 1)
                {
                    MessageBox.Show("Benutzername und Passwort sind Duplicate !");
                }
                if (count < 1)
                {
                    MessageBox.Show("Benutzername und Passwort sind nicht Korrekt !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqliteCon.Close();
        }

        private void txt_password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Konto Konto_fen = new Konto();
            Konto_fen.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            P_Vergessen window = new P_Vergessen();
            window.Show();
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }
    }
}
