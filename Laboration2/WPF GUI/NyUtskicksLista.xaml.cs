using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for NyUtskicksLista.xaml
    /// </summary>
    public partial class NyUtskicksLista : Window
    {
        public BusinessManager BusinessManager { get; }
        public NyUtskicksListaViewModel vm { get; set; }
        public NyUtskicksLista(BusinessManager businessManager)
        {
            InitializeComponent();
            BusinessManager = businessManager;
            vm = new NyUtskicksListaViewModel(BusinessManager);
            DataContext = vm;
        }

        private void Spara(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Vill du spara Utskickslistan såhär?", "Spara?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                ObservableCollection<Alumn> A = new ObservableCollection<Alumn>();

                foreach (Alumn a in MottagareBox.SelectedItems)
                {
                    Alumn alumn = BusinessManager.GetAlumn(a.AnvändarId);
                    A.Add(alumn);
                }

                vm.Alumner = A;
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
