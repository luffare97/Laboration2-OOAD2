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
    /// Interaction logic for RedigeraAktivitet.xaml
    /// </summary>
    public partial class RedigeraAktivitet : Window
    {
        public BusinessManager BusinessManager { get; }
        public RedigeraAktivitetViewModel vm { get; }
        public RedigeraAktivitet(BusinessManager businessManager, Aktivitet A)
        {
            InitializeComponent();
            BusinessManager = businessManager;
            vm = new RedigeraAktivitetViewModel(BusinessManager, A);
            DataContext = vm;

            if (vm.TillbakaAction == null)
                vm.TillbakaAction = new Action(this.Close);
        }

        //private void Spara(Object sender, RoutedEventArgs e)
        //{
        //    MessageBoxResult result = MessageBox.Show("Är du säker på att du vill spara ändringarna?", "Är du säker?", MessageBoxButton.YesNo);
        //    if (result == MessageBoxResult.Yes)
        //    {
        //        vm.Spara();
        //        this.DialogResult = false;
        //    }
        //    else if (result == MessageBoxResult.No)
        //    {
        //        this.DialogResult = false;
        //    }
            
        //}

        //private void Radera(Object sender, RoutedEventArgs e)
        //{
        //    MessageBoxResult result = MessageBox.Show("Är du säker på att du vill radera den här aktiviteten?","Är du säker?", MessageBoxButton.YesNo);
        //    if (result == MessageBoxResult.Yes)
        //    {
        //        vm.Radera();
        //        this.DialogResult = true;
        //    }
        //    else if (result == MessageBoxResult.No)
        //    {
        //        this.DialogResult = false;
        //    }
            

        //}

        //private void Tillbaka(Object sender, RoutedEventArgs e)
        //{
        //    this.DialogResult = false;
        //    this.Close();
        //}
    }
}
