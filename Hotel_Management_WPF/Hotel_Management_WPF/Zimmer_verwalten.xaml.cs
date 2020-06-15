/*
Name: Hilmi iliass
Room management
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
using System.Data;

namespace Hotel_Management_WPF
{
    /// <summary>
    /// Interaktionslogik für Zimmer_verwalten.xaml
    /// </summary>
    public partial class Zimmer_verwalten : Window
    {
        public Zimmer_verwalten()
        {
            InitializeComponent();
        }
        string dbConnectionString = @"Data Source =Hotel_DB.db;Version=3;";

        void FillDataGrid() {
            DataTable dt = new DataTable();
            DataColumn Id = new DataColumn("id",typeof(int));
            DataColumn Type = new DataColumn("Type",typeof(string));
            DataColumn Preis = new DataColumn("Preis",typeof(string));
            dt.Columns.Add(Id);
            dt.Columns.Add(Type);
            dt.Columns.Add(Preis);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            //string Query = " SELECT Buchung_nummer fROM Buchen";
            //string Query = " SELECT Buchung_nummer, Name , Vorname, Geburtsdatum , type , Preis_zimmer from Buchung,Kunden,Zimmer WHERE Buchung.Kunden_id = Kunden.Kunden_id And Buchung.Zimmer_id = Zimmer.Zimmer_id  ";
            //string Query = " SELECT Buchung_nummer, Name , Vorname, Geburtsdatum , type , Preis_zimmer from Buchung,Kunden,Zimmer WHERE Von between '" +datapicke1.ToString()+ "' AND Bis'" + datapik2.ToString() + "' And Buchung.Kunden_id = Kunden.Kunden_id And Buchung.Zimmer_id = Zimmer.Zimmer_id And Buchung.Zimmer_id = Zimmer.Zimmer_id";
            string Query = " SELECT Zimmer_id, type, Preis from Zimmer where statut = 'true'" ;
            //string Query = "SELECT * FROM Buchung JOIN Kunden , Zimmer ON Buchung.Kunden_id = Kunden.Kunden_id And Buchung.Zimmer_id = Zimmer.Zimmer_id WHERE Buchung_nummer = @Buchungsnummer";
            //string Query = " SELECT Buchung_nummer from Buchung";
            SQLiteCommand CreateCommand = new SQLiteCommand(Query, sqliteCon);
            SQLiteDataAdapter da = new SQLiteDataAdapter(CreateCommand);
            // SQLiteDataReader reader;
            // reader = CreateCommand.ExecuteReader();
            // Z_dataGrid.ItemsSource = reader;

            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                this.Z_dataGrid.ItemsSource = dt.AsDataView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errrrrrrror");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            sqliteCon.Open();
            string Query = "update Zimmer set Statut = 'true' where statut = 'false' ";
            SQLiteCommand CreateCommand = new SQLiteCommand(Query, sqliteCon);
            CreateCommand.ExecuteNonQuery();
            MessageBox.Show("Alle zimmern sind frei gegeben");
        }

        private void btn_abbrechen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
