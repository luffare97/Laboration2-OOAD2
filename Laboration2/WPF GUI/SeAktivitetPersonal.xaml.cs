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
            DataContext = vm;
            FyllLB(A);
            
        }
        public void FyllLB(Aktivitet A)
        {
            foreach (Alumn a in A.Deltagare)
            {
                Alumner.Add(a);
            }
        }

        public ObservableCollection<Alumn> alumner = new ObservableCollection<Alumn>();
        private ObservableCollection<Alumn> Alumner
        {
            get { return alumner; }
            set
            {
                alumner = value;
                
            }
        }


        private void Redigera(object sender, RoutedEventArgs e)
        {
            RedigeraAktivitet redigera = new RedigeraAktivitet(BusinessManager, vm.Aktivitet);
            redigera.ShowDialog();

            if (redigera.DialogResult == true)
            {
                StartPersonal start = new StartPersonal(BusinessManager);
                this.Close();
                start.ShowDialog();
                
            }
            else if (redigera.DialogResult == false)
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
