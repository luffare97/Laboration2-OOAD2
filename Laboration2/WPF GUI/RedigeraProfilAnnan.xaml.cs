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
using BusinessEntites;
using BusinessLayer;
using WPF_GUI.ViewModel;

namespace WPF_GUI
{
    /// <summary>
    /// Interaction logic for RedigeraProfilAnnan.xaml
    /// </summary>
    public partial class RedigeraProfilAnnan : Window
    {

        
        public BusinessManager BusinessManager { get; }
        public RedigeraProfilAnnanViewModel vm { get; set; }
        public RedigeraProfilAnnan(BusinessManager businessManager)
        {
            InitializeComponent();
            BusinessManager = businessManager;
            vm = new RedigeraProfilAnnanViewModel(BusinessManager);
            DataContext = vm;
        }



        private void RedigeraInfo(object sender, RoutedEventArgs e)
        {

            vm.SparaInfo();
            MessageBox.Show("Informationen har nu uppdaterats","Sparat");
        }

        private void RedigeraLösen(object sender, RoutedEventArgs e)
        {

            if (BusinessManager.InloggadAlumn.Lösenord == GammaltLösen.Text)
            {
                if (NyttLösen.Text == UpprepaLösen.Text)
                {
                    string nytt = NyttLösen.Text;
                    vm.SparaLösen(nytt);
                    MessageBox.Show("Ditt nya löseord har nu sparats", "Sparat");
                    GammaltLösen.Clear();
                    NyttLösen.Clear();
                    UpprepaLösen.Clear();
                }
                else
                {
                    MessageBox.Show("Nya lösenord stämmer inte överrens", "Error");
                }
            }
            else
            {
                MessageBox.Show("Fel gammalt lösenord", "Error");
            }
            
        }

        private void TillbakaBtn(object sender, RoutedEventArgs e)
        {
            vm.Tillbaka();
            this.Close();
        }

    }
}
