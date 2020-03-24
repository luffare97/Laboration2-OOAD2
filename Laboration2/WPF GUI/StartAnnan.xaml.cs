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
    /// Interaction logic for StartAnnan.xaml
    /// </summary>
    public partial class StartAnnan : Window
    {

        public BusinessManager BusinessManager { get; }

        public StartAnnan(BusinessManager businessManager)
        {
            InitializeComponent();
            BusinessManager = businessManager;
            StartAnnanViewModel vm = new StartAnnanViewModel(BusinessManager);
            DataContext = vm;
        }

        private void RedigeraProfil(object sender, RoutedEventArgs e)
        {
            RedigeraProfilAnnan RedigeraProfil = new RedigeraProfilAnnan(BusinessManager);
            RedigeraProfil.ShowDialog();
            
            if (RedigeraProfil.DialogResult == true)
            {
                MainWindow loggIn = new MainWindow();
                this.Close();
                loggIn.ShowDialog();
            }
            else if (RedigeraProfil.DialogResult == false)
            {

            }
        }

        private void LoggaUt(object sender, RoutedEventArgs e)
        {
            MainWindow loggIn = new MainWindow();
            this.Close();
            loggIn.ShowDialog();
        }

        private void VäljLista(object sender, RoutedEventArgs e)
        {
            SeUtskicksListaAnnan seUtskicksLista = new SeUtskicksListaAnnan(BusinessManager);
            
            seUtskicksLista.ShowDialog();
        }

        private void VäljAktivitet(object sender, RoutedEventArgs e)
        {
            SeAktivitetAnnan seAktivitet = new SeAktivitetAnnan(BusinessManager);
            
            seAktivitet.ShowDialog();
        }

    }
}
