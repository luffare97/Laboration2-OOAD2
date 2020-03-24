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
    /// Interaction logic for RedigeraProfilPersonal.xaml
    /// </summary>
    public partial class RedigeraProfilPersonal : Window
    {
        public BusinessManager BusinessManager { get; }
        public RedigeraProfilPersonalViewModel vm { get; set; }
        public RedigeraProfilPersonal(BusinessManager businessManager)
        {
            InitializeComponent();
            BusinessManager = businessManager;
            vm = new RedigeraProfilPersonalViewModel(BusinessManager);
            DataContext = vm;
        }


        private void RedigeraInfo(object sender, RoutedEventArgs e)
        {

            vm.SparaInfo();
            MessageBox.Show("Informationen har nu uppdaterats", "Sparat");
        }

        private void RedigeraLösen(object sender, RoutedEventArgs e)
        {

            if (BusinessManager.InloggadPersonal.Lösenord == GammaltLösen.Password)
            {
                if (NyttLösen.Password == UpprepaLösen.Password)
                {
                    string nytt = NyttLösen.Password;
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

        private void Radera(object sender, RoutedEventArgs e)
        {
            RaderaKonto radera = new RaderaKonto(BusinessManager);
            radera.ShowDialog();
            if (radera.DialogResult == true)
            {
                this.DialogResult = true;
                this.Close();
            }
            else if (radera.DialogResult == false)
            {
                this.DialogResult = false;
            }
        }

        private void TillbakaBtn(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            vm.Tillbaka();
            this.Close();
        }

    }
}
