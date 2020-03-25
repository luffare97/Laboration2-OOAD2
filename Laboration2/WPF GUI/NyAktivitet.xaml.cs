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
    /// Interaction logic for NyAktivitet.xaml
    /// </summary>
    public partial class NyAktivitet : Window
    {
        public BusinessManager BusinessManager { get; }
        public NyAktivitetViewModel vm { get; set; }
        public NyAktivitet(BusinessManager businessManager)
        {
            InitializeComponent();
            BusinessManager = businessManager;
            vm = new NyAktivitetViewModel(BusinessManager);
            DataContext = vm;
        }

        private void Spara(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Vill du spara aktiviteten såhär?","Spara?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                vm.Spara();
                StartPersonal start = new StartPersonal(BusinessManager);
                this.Close();
                start.ShowDialog();
            }
            else
            {

            }
            
        }

        private void Tillbaka(object sender, RoutedEventArgs e)
        {
            StartPersonal start = new StartPersonal(BusinessManager);
            this.Close();
            start.ShowDialog();
        }
    }
}
