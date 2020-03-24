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
        public BusinessManager businessManager { get; }

        public MainWindow()
        {
            InitializeComponent();
            businessManager = vm.businessManager;
            DataContext = vm;
        }

        private void LoggaIn(object sender, RoutedEventArgs e)
        {
            Användare A = vm.LoggaIn(AnvändarIDTxt.Text, LösenordTxt.Password);

            if (A == null)
            {
                MessageBox.Show("AnvändarIDt och lösenorder matchar inte","Error");
            }
            else if(A.Lösenord == LösenordTxt.Password)
            {
                if ((A as Personal) != null)
                {
                    businessManager.InloggadPersonal = A as Personal;
                    StartPersonal startPersonal = new StartPersonal(businessManager);
                    this.Close();
                    startPersonal.ShowDialog();

                    //businessManager.InloggadPersonal = null;
                    //AnvändarIDTxt.Clear();
                    //LösenordTxt.Clear();
                }
                else if ((A as Alumn) != null)
                {
                    businessManager.InloggadAlumn = A as Alumn;
                    StartAnnan startAnnan = new StartAnnan(businessManager);
                    this.Close();
                    startAnnan.ShowDialog();

                    //businessManager.InloggadAlumn = null;
                    //AnvändarIDTxt.Clear();
                    //LösenordTxt.Clear();
                }
            }
        }

        private void Registrering(object sender, RoutedEventArgs e)
        {
            Registrering registrering = new Registrering(businessManager);
            registrering.ShowDialog();
        }
    }
}
