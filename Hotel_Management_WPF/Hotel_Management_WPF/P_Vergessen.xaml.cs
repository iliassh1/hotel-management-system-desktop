/*
Name: Hilmi Iliass
Login and registration
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
using System.Windows.Shapes;
using System.Data.SQLite;

namespace Hotel_Management_WPF
{
    /// <summary>
    /// Interaktionslogik für P_Vergessen.xaml
    /// </summary>
    public partial class P_Vergessen : Window
    {

        string dbConnectionString = @"Data Source=Hotel_DB.db; Version= 3;";
        public P_Vergessen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            // Verbindung mit dem DB öffenen
            try
            {
                sqliteCon.Open();
                string Query = "select Passwort, Benutzer_login from Benutzer where Email = '" + this.txt_email2.Text+"' and Geburtsdatum = '"+this.txt_gd.Text+"'";
                SQLiteCommand CreateCommand = new SQLiteCommand(Query, sqliteCon);
                CreateCommand.ExecuteNonQuery();
                SQLiteDataReader reader = CreateCommand.ExecuteReader();
                int count = 0;
                string benutzer = reader["Benutzer_login"].ToString();
                string password = reader["Passwort"].ToString();
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("Ihr Benutzer Name lautet: " + benutzer);
                    MessageBox.Show("Ihr Passwort lautet: "+password);
                    /*
                    string Query2 = "select Passwort from Benutzer where  Email = '" + this.txt_email2.Text+ "'";
                    SQLiteCommand CreateCommand2 = new SQLiteCommand(Query2, sqliteCon);
                    CreateCommand2.ExecuteNonQuery();
                    SQLiteDataReader reader2 = CreateCommand.ExecuteReader();
                    find = CreateCommand2.ExecuteScalar().ToString();
                    MessageBox.Show("Your password is "+find);
                    */
                }
                if (count > 1)
                {
                    MessageBox.Show("Kein Konto Mit den eingegebene Daten Vorhanden","Info",MessageBoxButton.OK,MessageBoxImage.Information);
                }

                if (count < 1)
                {
                    MessageBox.Show("Kein Konto Mit den eingegebene Daten Vorhanden", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqliteCon.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
        }
    }
}
