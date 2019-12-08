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
using System.Data.SqlClient;
using System.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        internal void Show()
        {
            throw new NotImplementedException();
            
        }
        string dbConnectionString = @"Data Source =Hotel_DB.dbn;Version=3;";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);


            try
            {
                sqliteCon.Open();
                if (datapic1.Text == "" || datapic2.Text == "")                 //|| textbox3.Text == "" || textbox4.Text == "" || cmb1.Text =="")
                {
                    MessageBox.Show("Bitte Datum ausfüllen ");

                }
                else
                {
                    //string Query = " SELECT Buchung_nummer fROM Buchen";
                    //string Query = " SELECT Buchung_nummer, Name , Vorname, Geburtsdatum , type , Preis_zimmer from Buchung,Kunden,Zimmer WHERE Buchung.Kunden_id = Kunden.Kunden_id And Buchung.Zimmer_id = Zimmer.Zimmer_id  ";
                    //string Query = " SELECT Buchung_nummer, Name , Vorname, Geburtsdatum , type , Preis_zimmer from Buchung,Kunden,Zimmer WHERE Von between '" +datapicke1.ToString()+ "' AND Bis'" + datapik2.ToString() + "' And Buchung.Kunden_id = Kunden.Kunden_id And Buchung.Zimmer_id = Zimmer.Zimmer_id And Buchung.Zimmer_id = Zimmer.Zimmer_id";
                    string Query = " SELECT Buchung_nummer,Name , Vorname, Von, Bis, Datum , Preis   FROM Buchung ,Kunden WHERE Von between '" + datapic1.ToString() + "'and   '" + datapic2.ToString() + "' And Buchung.Kunden_id = Kunden.Kunden_id ";
                    //string Query = "SELECT * FROM Buchung JOIN Kunden , Zimmer ON Buchung.Kunden_id = Kunden.Kunden_id And Buchung.Zimmer_id = Zimmer.Zimmer_id WHERE Buchung_nummer = @Buchungsnummer";
                    //string Query = " SELECT Buchung_nummer from Buchung";
                    SQLiteCommand CreateCommand = new SQLiteCommand(Query, sqliteCon);
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(CreateCommand);
                    SQLiteDataReader reader;
                    reader = CreateCommand.ExecuteReader();
                    dataGrid.ItemsSource = reader;

                    //sqliteCon.Close();
                    //DataTable dt = new DataTable();
                    //dataAdapter.Fill(dt);
                    //dataGrid.DataSource = dt;




                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
   
}
