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

namespace Hotel_Management_WPF
{
    /// <summary>
    /// Interaktionslogik für NavPage.xaml
    /// </summary>
    public partial class NavPage : Page
    {

       
        public NavPage()
        {
            InitializeComponent();
            Start.Content = new Page1();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             Start.Content = new Page1();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Start.Content = new Page_Buchung();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Start.Content = new Page_Umbuchung();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Start.Content = new Report2();
            
        }

        private void btn_zimmer(object sender, RoutedEventArgs e)
        {
            Zimmer_verwalten win2 = new Zimmer_verwalten();
            win2.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            (this.Parent as Window).Close();
        }
    }
}
