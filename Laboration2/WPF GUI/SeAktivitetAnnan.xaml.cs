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
    /// Interaction logic for SeAktivitetAnnan.xaml
    /// </summary>
    public partial class SeAktivitetAnnan : Window
    {
        public BusinessManager BusinessManager { get; }
        public SeAktivitetAnnanViewModel vm { get; }
        public SeAktivitetAnnan(BusinessManager businessManager, Aktivitet A)
        {
            InitializeComponent();
            BusinessManager = businessManager;
            vm = new SeAktivitetAnnanViewModel(BusinessManager, A);
            DataContext = vm;
        }

        private void Delta(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Vill du Delta i den här aktiviteten?","Är du säker?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                vm.Delta();
                MessageBox.Show("Du kommer nu att delta i den här aktiviteten","Yay");
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
