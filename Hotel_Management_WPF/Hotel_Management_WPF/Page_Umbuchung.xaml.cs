/* Dieser Code Anteil wurde geschrieben von:
Name: Hilmi
Vorname : Iliass
Immatrikulation Nummer : 672515
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
    /// Interaktionslogik für Page_Umbuchung.xaml
    /// </summary>
    /// 

    

    public partial class Page_Umbuchung : Page
    {


        string dbConnectionString = @"Data Source=Hotel_DB.db; Version= 3;";
        public Page_Umbuchung()
        {
            InitializeComponent();
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Glbale variable um den Wert from txt_suche zu speichern
            MyGlobals.B_Suche = txt_Suche.Text;
            


            // Verbindung mit dem DB öffenen
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);

            try
            {

                sqliteCon.Open();
                string Query = "select * from Buchung where Buchung_nummer = '" + MyGlobals.B_Suche + "';";
                SQLiteCommand CreateCommand = new SQLiteCommand(Query, sqliteCon);


                CreateCommand.ExecuteNonQuery();
                SQLiteDataReader reader = CreateCommand.ExecuteReader();



                // Informationnen von dem DatenBank holen

               while (reader.Read())
                {


                    string buch_nummer = reader["Buchung_nummer"].ToString();
                    // valcheck für überprüfung um die Buchnummer in Datenbank existiert
                    MyGlobals.Valcheck = Int32.Parse(buch_nummer);

                }
                // falls den gesuchten Wert in datenbank existiert 
                if ( MyGlobals.Valcheck  == Int32.Parse(txt_Suche.Text))
                {
                    Umbuchung_Fenster win4 = new Umbuchung_Fenster();
                    win4.Show();
                }
                else
                {

                    MessageBox.Show("Diese Bucuhung Nummer ist nicht vorhaden");
                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);




            } 
            sqliteCon.Close();

           
            
        }

        private void txt_Suche_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

    
}




