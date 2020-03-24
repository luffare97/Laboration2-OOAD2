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
    /// Interaction logic for SeUtskicksListaPersonal.xaml
    /// </summary>
    public partial class SeUtskicksListaPersonal : Window
    {
        public BusinessManager BusinessManager { get; }
        public SeUtskicksListaPersonalViewModel vm { get; }
        public SeUtskicksListaPersonal(BusinessManager businessManager, UtskicksLista utskicksLista)
        {
            InitializeComponent();
            BusinessManager = businessManager;
            vm = new SeUtskicksListaPersonalViewModel(BusinessManager, utskicksLista);
            DataContext = vm;
        }



        private void Redigera(object sender, RoutedEventHandler e)
        {
            RedigeraLista redigera = new RedigeraLista(BusinessManager, vm.Lista);
            redigera.ShowDialog();
            
            if (redigera.DialogResult == true)
            {
                this.Close();
            }
            else if (redigera.DialogResult == false)
            {

            }
        }

        private void Tillbaka(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
