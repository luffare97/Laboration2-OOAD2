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
    /// Interaction logic for SeAktivitetPersonal.xaml
    /// </summary>
    public partial class SeAktivitetPersonal : Window
    {
        public BusinessManager BusinessManager { get; }
        public SeAktivitetPersonalViewModel vm { get; set; }
        public SeAktivitetPersonal(BusinessManager businessManager, Aktivitet A)
        {
            InitializeComponent();
            BusinessManager = businessManager;
            vm = new SeAktivitetPersonalViewModel(BusinessManager, A);
        }

        private Aktivitet aktivitet = new Aktivitet();
        public Aktivitet Aktivitet
        {
            get { return aktivitet; }
            set
            {
                aktivitet = value;
            }
        }

        private void Redigera(object sender, RoutedEventHandler e)
        {
            RedigeraAktivitet redigera = new RedigeraAktivitet(BusinessManager, Aktivitet);
            redigera.ShowDialog();

            if (redigera.DialogResult == true)
            {
                this.Close();
            }
            else if (redigera.DialogResult == false)
            {

            }
        }

        private void Tillbaka(object sender, RoutedEventHandler e)
        {
            this.Close();
        }
    }
}
