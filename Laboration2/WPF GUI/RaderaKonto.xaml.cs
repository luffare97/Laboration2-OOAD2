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
    /// Interaction logic for RaderaKonto.xaml
    /// </summary>
    public partial class RaderaKonto : Window
    {
        
        public BusinessManager BusinessManager { get; }
        public RaderaKontoViewModel vm { get; set; }
        public RaderaKonto(BusinessManager businessManager)
        {
            InitializeComponent();
            BusinessManager = businessManager;
            vm = new RaderaKontoViewModel(BusinessManager);
            DataContext = vm;

            if (vm.TillbakaAction == null)
                vm.TillbakaAction = new Action(this.Close);
        }
        

        //private void Radera(object sender, RoutedEventArgs e)
        //{
        //    if (Lösen1.Password == Lösen2.Password)
        //    {
        //        if (Lösen1.Password == BusinessManager.InloggadAlumn.Lösenord)
        //        {
        //            MessageBoxResult result = MessageBox.Show("Är du säker på att du vill ta bort kontot?", "Är du säker?", MessageBoxButton.YesNo);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                vm.Radera();
        //                MessageBox.Show("Ditt konto har nu raderats och du kommer att tas tillbaka till loggin skärmen","Raderat");
        //                this.DialogResult = true;
        //            }
        //            else if (result == MessageBoxResult.No)
        //            {
        //                this.DialogResult = false;
        //            }
                    
        //        }
        //        else
        //        {
        //            MessageBox.Show("Fel lösenord", "Error");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Lösenorden matchade inte","Error");
        //    }
            
        //}

        //private void Tillbaka(object sender, RoutedEventArgs e)
        //{
        //    this.DialogResult = false;
        //    this.Close();
        //} 
    }
}
