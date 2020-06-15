/*
Name: Iliass Hilmi
manage booking operations
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
    /// Interaktionslogik für Page_Buchung.xaml
    /// </summary>
    public partial class Page_Buchung : Page
    {
        string dbConnectionString = @"Data Source=Hotel_DB.db; Version= 3;";
        int Global_Preis = 0, Global_Geb = 0, kunden_id = 0;
        string max;

        public Page_Buchung()
            
        {
            InitializeComponent();
            fillmycombo();
            dp_von.SelectedDate = DateTime.Today;
            dp_bis.SelectedDate = DateTime.Today;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cmbx_zimmer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        void fillmycombo()
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            // Verbindung mit dem DB öffenen
            try
            {
                sqliteCon.Open();
                string Query = "select type from zimmer where Statut = 'true';";
                SQLiteCommand CreateCommand = new SQLiteCommand(Query, sqliteCon);
                CreateCommand.ExecuteNonQuery();
                SQLiteDataReader reader = CreateCommand.ExecuteReader();

                while (reader.Read())
                {
                    string stype = reader["type"].ToString();
                    cmbx_zimmer.Items.Add(stype);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqliteCon.Close();
        }

        /* Funktion für entleerung von dem From */

        private void UpdateForm()
        {
            txt_name.Text = "";
            txt_telefon.Text = "";
            txt_vorname.Text = "";
            txt_Pass.Text = "";
            dp_bis.Text = "";
            dp_von.Text = "";
            dp_geb.Text = "";
            lbl_preis.Content = "";
            lbl_buchung.Content = Int32.Parse(max) + 2;
        }
        /* funktion für die selection von der max Buchung Nummer */
        private void Bnummer()
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            // Verbindung mit dem DB öffenen

            try
            {
                sqliteCon.Open();
                string Query = "SELECT * FROM Buchung where Buchung_nummer = (select max(Buchung_nummer) from Buchung);";
                SQLiteCommand CreateCommand = new SQLiteCommand(Query, sqliteCon);
                CreateCommand.ExecuteNonQuery();
                SQLiteDataReader reader = CreateCommand.ExecuteReader();
                while (reader.Read())
                {
                     max = reader["Buchung_nummer"].ToString();
                    lbl_buchung.Content = Int32.Parse(max) +1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqliteCon.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbx_sonstige.Items.Add("Frühstück (12 €)");
            cmbx_sonstige.Items.Add("Frühstück + M (25 €)");
            cmbx_sonstige.Items.Add("F+M+A (30€)");
            Bnummer(); // Buchung Nummer funktion
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            // Verbindung mit dem DB öffenen

            try
            {
                sqliteCon.Open();
                string Query = "insert into Kunden (Name, Vorname, Datum, Tel,Passport) values ('" + txt_name.Text + "','" + txt_vorname.Text + "','" + dp_geb.Text + "','" + txt_telefon.Text + "','" + txt_Pass.Text + "') ";
                SQLiteCommand CreateCommand = new SQLiteCommand(Query, sqliteCon);
                CreateCommand.ExecuteNonQuery();
                // Max wert von table Kunden colun kunden_id
                string Query2 = "SELECT Kunden_id FROM Kunden where Kunden_id = (select max(Kunden_id) from Kunden);";
                SQLiteCommand comm2 = new SQLiteCommand(Query2, sqliteCon);
                comm2.ExecuteNonQuery();
                SQLiteDataReader reader = comm2.ExecuteReader();

                while (reader.Read())
                {
                    string str = reader["Kunden_id"].ToString();
                    kunden_id = Int32.Parse(str);
                }
                string Query3 = "insert into Buchung (kunden_id,Sonstige, Von, Bis,Preis,Passport) values ('" + kunden_id + "','" + cmbx_sonstige.Text + "','" + dp_von.Text + "','" + dp_bis.Text + "','" + Global_Preis + "','" + txt_Pass.Text + "' ) ";
                string Query4 = "update Zimmer set Statut = 'false' where type = '" + cmbx_zimmer.Text + "'";
                SQLiteCommand Command3 = new SQLiteCommand(Query3, sqliteCon);
                SQLiteCommand Command4 = new SQLiteCommand(Query4, sqliteCon);
                Command3.ExecuteNonQuery();
                MessageBox.Show("neue Buchung ist erflogreich eingefügt");
                Command4.ExecuteNonQuery();
                UpdateForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqliteCon.Close();
        }

        private void cmd_abb_Click(object sender, RoutedEventArgs e)
        {
            NavPage win2 = new NavPage();
            win2.Content = win2;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult ergebnis = MessageBox.Show("Möchten Sie wirklich die Apps vollständig Schließen", "Achtung", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
            if (ergebnis == MessageBoxResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void txt_name_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cmbx_zimmer_DropDownClosed(object sender, EventArgs e)
        {
            string gebuchte_tage;
            // Datum Diffrence 
            // Zahl die Gebuchte Tage
            DateTime start = dp_von.SelectedDate.Value.Date;
            DateTime finish = dp_bis.SelectedDate.Value.Date;
            TimeSpan difference = finish.Subtract(start);

            //  txt_telefon.Text = Convert.ToString(difference);
            gebuchte_tage = difference.TotalDays.ToString();

            // Verbindung mit dem DB öffenen
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);

            // Funktion Preisen holen
            void Preis_holen()
            {
                sqliteCon.Open();
                string Query = "select Preis from Zimmer where type ='" + cmbx_zimmer.Text + "'";
                SQLiteCommand CreateCommand = new SQLiteCommand(Query, sqliteCon);
                CreateCommand.ExecuteNonQuery();
                SQLiteDataReader reader = CreateCommand.ExecuteReader();

                while (reader.Read())
                {
                    string preis = reader["Preis"].ToString();
                    int i = Int32.Parse(gebuchte_tage);
                    int j = Int32.Parse(preis);
                    lbl_preis.Content = i * j;

                    // für die Gebuchte Tage
                    Global_Geb = i;
                    // für die Global preise
                    Global_Preis = i * j;
                    // global preis+ buch_funk();
                    i = 0;
                    j = 0;
                }
            }
            Preis_holen();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            cmbx_sonstige.Items.Add("Frühstück (12 €)");
            cmbx_sonstige.Items.Add("Frühstück + M (25 €)");
            cmbx_sonstige.Items.Add("F+M+A (30€)");
            Bnummer();
        }

        private void cmbx_sonstige_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmbx_sonstige_DropDownClosed(object sender, EventArgs e)
        {
            int F = 0, FM = 0, FMA = 0;
            if (cmbx_sonstige.Text == "Frühstück (12 €)")
            {
                F = 12 * Global_Geb;
            }
            else if (cmbx_sonstige.Text == "Frühstück + M (25 €)")
            {
                FM = 25 * Global_Geb;
            }
            else
            {
                FMA = 30 * Global_Geb;
            }

            Global_Preis = Global_Preis + F + FM + FMA;
            lbl_preis.Content = Global_Preis;
            Global_Preis = 0;
        }
    }
}
