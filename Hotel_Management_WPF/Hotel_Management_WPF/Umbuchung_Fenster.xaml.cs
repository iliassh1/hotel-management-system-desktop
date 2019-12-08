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
using System.Windows.Shapes;
using System.Data.SQLite;
namespace Hotel_Management_WPF
{
    /// <summary>
    /// Interaktionslogik für Umbuchung_Fenster.xaml
    /// </summary>
    public partial class Umbuchung_Fenster : Window
    {

        string dbConnectionString = @"Data Source=Hotel_DB.db; Version= 3;";
        int Global_Preis = 0, Global_Geb = 0, kunden_id = 0;

        public Umbuchung_Fenster( )
        {
            InitializeComponent();
            fillmycombo();

            
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


        private void cmd_abb_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_Speichern_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            sqliteCon.Open();

            string Query1 = "select * from Buchung where Buchung_nummer = '" + MyGlobals.B_Suche + "';";
            SQLiteCommand CreateCommand1 = new SQLiteCommand(Query1, sqliteCon);
            CreateCommand1.ExecuteNonQuery();
            SQLiteDataReader reader1 = CreateCommand1.ExecuteReader();
            while (reader1.Read())
            {

                string kun = reader1["Kunden_id"].ToString();
                kunden_id = Int32.Parse(kun);



            }



            string Query2 = "update Kunden set Name = '"+txt_name.Text+"', Vorname = '"+txt_vorname.Text+"', Datum = '"+dp_geb.Text+"', Tel = '"+txt_telefon.Text+"', Passport = '"+txt_Pass.Text+"' where Kunden_id = '"+kunden_id+"' ;";
            SQLiteCommand CreateCommand2 = new SQLiteCommand(Query2, sqliteCon);


            CreateCommand2.ExecuteNonQuery();

            string Query3 = "update Buchung set Sonstige = '" + cmbx_sonstige.Text + "', Von = '" + dp_von.Text + "', Bis = '" + dp_bis.Text + "' where Buchung_nummer = '" + MyGlobals.B_Suche + "' ;";
            SQLiteCommand CreateCommand3 = new SQLiteCommand(Query3, sqliteCon);


            CreateCommand3.ExecuteNonQuery();

            MessageBox.Show("Anderungen sind Erfolgreich gespeichert");
          






        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {


            cmbx_sonstige.Items.Add("Frühstück (12 €)");
            cmbx_sonstige.Items.Add("Frühstück + M (25 €)");
            cmbx_sonstige.Items.Add("F+M+A (30€)");


            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            // Verbindung mit dem DB öffenen


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
                   lbl_buchung.Content = buch_nummer;

                    string pass = reader["Passport"].ToString();
                    txt_Pass.Text = pass;

                   

                     string von = reader["Von"].ToString();
                    dp_von.Text = von;

                    string bis = reader["Bis"].ToString();
                    dp_bis.Text = bis;

                    string preis = reader["Preis"].ToString();
                    // lbl_preis.Content = preis;
                    MyGlobals.kundenId = reader["Kunden_id"].ToString();

                    txt_telefon.Text = MyGlobals.kundenId;

  

                }

                string Query2 = "select * from Kunden where Kunden_id = '" + MyGlobals.kundenId + "';";
                SQLiteCommand CreateCommand2 = new SQLiteCommand(Query2, sqliteCon);


                CreateCommand2.ExecuteNonQuery();
                SQLiteDataReader reader2 = CreateCommand2.ExecuteReader();

                // Informationnen von dem DatenBank holen

                while (reader2.Read()) {
                    string name, vorname, datum, tel;
                    name = reader2["Name"].ToString();
                    vorname = reader2["Vorname"].ToString();
                    tel = reader2["Tel"].ToString();
                    datum = reader2["Datum"].ToString();
                    txt_name.Text = name;
                    txt_vorname.Text = vorname;
                     txt_telefon.Text = tel;
                    dp_geb.Text = datum; 
                   
                    
                   
        


                }






            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);




            }
            sqliteCon.Close();
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
        }

        private void txt_name_TextChanged(object sender, TextChangedEventArgs e)
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
                    lbl_preis.Content = i * j ;


                    
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
    }
}
