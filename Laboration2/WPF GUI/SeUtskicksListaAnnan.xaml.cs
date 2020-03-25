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
    /// Interaction logic for SeUtskicksListaAnnan.xaml
    /// </summary>
    public partial class SeUtskicksListaAnnan : Window
    {
        public BusinessManager BusinessManager { get; }
        public SeUtskicksListaAnnanViewModel vm { get; set; }
        public SeUtskicksListaAnnan(BusinessManager businessManager, UtskicksLista L)
        {
            InitializeComponent();
            BusinessManager = businessManager;
            vm = new SeUtskicksListaAnnanViewModel(BusinessManager, L);
        }

        private void SlutaFölja(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Vill du sluta följa listan?", "Är du säker?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                vm.SlutaFölja();
                StartAnnan start = new StartAnnan(BusinessManager);
                this.Close();
                start.ShowDialog();
            }
            else
            {

            }

        }

        private void Tillbaka(object sender, RoutedEventArgs e)
        {
            StartAnnan start = new StartAnnan(BusinessManager);
            this.Close();
            start.ShowDialog();

        }
    }
}
