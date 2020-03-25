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
    /// Interaction logic for StartPersonal.xaml
    /// </summary>
    public partial class StartPersonal : Window
    {

        public BusinessManager BusinessManager { get; }

        public StartPersonal(BusinessManager businessManager)
        {
            InitializeComponent();

            BusinessManager = businessManager;

            StartPersonalViewModel vm = new StartPersonalViewModel(BusinessManager);
            dataGridAktiviteter.ItemsSource = vm.Aktiviteter;
            dataGridListor.ItemsSource = vm.Listor;
            DataContext = vm;
        }

        private void RedigeraProfil(object sender, RoutedEventArgs e)
        {
            RedigeraProfilPersonal RedigeraProfil = new RedigeraProfilPersonal(BusinessManager);

            RedigeraProfil.ShowDialog();
        }


        private void LoggaUt(object sender, RoutedEventArgs e)
        {
            MainWindow loggIn = new MainWindow();
            this.Close();
            loggIn.ShowDialog();
        }

        private void SkapaLista(object sender, RoutedEventArgs e)
        {
            NyUtskicksLista NyLista = new NyUtskicksLista(BusinessManager);
            this.Close();
            NyLista.ShowDialog();
        }

        private void VäljLista(object sender, RoutedEventArgs e)
        {
            UtskicksLista Lista = (UtskicksLista)dataGridListor.SelectedItem;
            
            SeUtskicksListaPersonal seUtskicksLista = new SeUtskicksListaPersonal(BusinessManager, Lista);
            this.Close();
            seUtskicksLista.ShowDialog();
        }

        private void SkapaAktivitet(object sender, RoutedEventArgs e)
        {
            NyAktivitet nyAktivitet = new NyAktivitet(BusinessManager);
            this.Close();
            nyAktivitet.ShowDialog();
        }

        private void VäljAktivitet(object sender, RoutedEventArgs e)
        {
            Aktivitet Aktivitet = (Aktivitet)dataGridAktiviteter.SelectedItem;

            SeAktivitetPersonal seAktivitet = new SeAktivitetPersonal(BusinessManager, Aktivitet);
            this.Close();
            seAktivitet.ShowDialog();
        }

    }
}
