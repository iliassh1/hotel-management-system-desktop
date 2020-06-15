/*
Name: Hilmi Iliass
Registration
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
    /// Interaktionslogik für Konto.xaml
    /// </summary>
    public partial class Konto : Window
    {
        public void Fieldempty() {
            txt_benutzer.Text = "";
            txt_email.Text = "";
            txt_name.Text = "";
            txt_vorname.Text = "";
            dp_geburt2.Text = "";
            txt_Password.Password = "";
            txt_PasswW.Password = "";
        }
        // Funktion um die Daten zu Validieren
        public bool ValidateDate(string date)
        {
            try
            {
                // for US, alter to suit if splitting on hyphen, comma, etc.
                string[] dateParts = date.Split('/');

                // create new date from the parts; if this does not fail
                // the method will return true and the date is valid
                DateTime testDate = new
                    DateTime(Convert.ToInt32(dateParts[2]),
                    Convert.ToInt32(dateParts[0]),
                    Convert.ToInt32(dateParts[1]));
                return true;
            }
            catch
            {
                // if a test date cannot be created, the
                // method will return false
                return false;
            }
        }
        string dbConnectionString = @"Data Source=Hotel_DB.db; Version= 3;";
        public Konto()
        {
            InitializeComponent();
        }

        private void btn_b_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            // Verbindung mit dem DB öffenen

            try
            {
                sqliteCon.Open();
                string Query = "insert into Benutzer (Name, Vorname, Geburtsdatum,Email,Benutzer_login, Passwort) values ('"+this.txt_name.Text+"','"+this.txt_vorname.Text+"','"+this.dp_geburt2.Text+"','"+this.txt_email.Text+"','"+this.txt_benutzer.Text+"','" + this.txt_Password.Password  +"')"; 
                SQLiteCommand CreateCommand = new SQLiteCommand(Query, sqliteCon);
                if (txt_vorname.Text == "" ||  txt_name.Text == " " || dp_geburt2.Text == "" || txt_email.Text=="" || txt_Password.Password=="" || txt_PasswW.Password=="" ) {
                    MessageBox.Show("Sie müssen alle Felder ausfüllen");

                }
                else {
                     if (txt_Password.Password == txt_PasswW.Password)
                     {
                         if (Check1.IsChecked == true)
                         {
                               CreateCommand.ExecuteNonQuery();
                                MessageBox.Show("Das Konto ist Erfolgreich Erstellt");
                                Fieldempty();

                         }
                         else {
                                MessageBox.Show("Sie müssne die Nutzung Bedingungen zustimmen");
                         }
                     }
                    else {
                           MessageBox.Show("das Passwort entspricht nicht");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqliteCon.Close();
        }
    private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}

