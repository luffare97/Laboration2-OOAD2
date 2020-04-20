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
    /// Interaction logic for RedigeraLista.xaml
    /// </summary>
    public partial class RedigeraLista : Window
    {
        public BusinessManager BusinessManager { get; }
        public RedigeraListaViewModel vm { get; set; }
        public RedigeraLista(BusinessManager businessManager, UtskicksLista utskicksLista)
        {
            InitializeComponent();
            BusinessManager = businessManager;
            vm = new RedigeraListaViewModel(BusinessManager, utskicksLista);
            DataContext = vm;

            if (vm.TillbakaAction == null)
                vm.TillbakaAction = new Action(this.Close);
        }

        //private void Radera(object sender, RoutedEventArgs e)
        //{
        //    MessageBoxResult result = MessageBox.Show("Är du säker på att du vill radera den här listan?", "Radera?", MessageBoxButton.YesNo);
        //    if (result == MessageBoxResult.Yes)
        //    {
        //        vm.Radera();
        //        MessageBox.Show("Ändringara har blivit Raderad", "Raderad");
        //        this.Close();
        //    }
        //    else if (result == MessageBoxResult.No)
        //    {

        //    }
        //}

        //private void Spara(object sender, RoutedEventArgs e)
        //{
        //    MessageBoxResult result = MessageBox.Show("Är du säker på att du vill spara ändringarna?","Spara?",MessageBoxButton.YesNo);
        //    if (result == MessageBoxResult.Yes)
        //    {
        //        vm.Spara();
        //        MessageBox.Show("Ändringara har blivit sparade","Sparat");
        //    }
        //    else if (result == MessageBoxResult.No)
        //    {

        //    }
            
        
        //}

        //private void Tillbaka(object sender, RoutedEventArgs e)
        //{
        //    this.Close();
        //}

    }
}
