using BusinessEntites;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_GUI.ViewModel;
using BusinessLayer;

namespace WPF_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LoggInViewModel vm = new LoggInViewModel();
        //public BusinessManager BusinessManager { get; }

        public MainWindow()
        {
            InitializeComponent();
            //BusinessManager = new BusinessManager();
            DataContext = vm;
        }

        //private void LoggaIn(object sender, RoutedEventArgs e)
        //{
        //    Användare A = vm.LoggaIn(AnvändarIDTxt.Text, LösenordTxt.Password);

        //    if (A == null)
        //    {
        //        MessageBox.Show("AnvändarIDt och lösenorder matchar inte","Error");
        //    }
        //    else if(A.Lösenord == LösenordTxt.Password)
        //    {
        //        if ((A as Personal) != null)
        //        {
        //            BusinessManager.InloggadPersonal = A as Personal;
        //            StartPersonal startPersonal = new StartPersonal(BusinessManager);
        //            this.Close();
        //            startPersonal.ShowDialog();

        //        }
        //        else if ((A as Alumn) != null)
        //        {
        //            BusinessManager.InloggadAlumn = A as Alumn;
        //            StartAnnan startAnnan = new StartAnnan(BusinessManager);
        //            this.Close();
        //            startAnnan.ShowDialog();

        //        }
        //    }
        //}

        //private void Registrering(object sender, RoutedEventArgs e)
        //{
        //    Registrering registrering = new Registrering(BusinessManager);
        //    registrering.ShowDialog();
        //}
    }
}
