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
            DataContext = vm;
        }

        private void LoggaIn(object sender, RoutedEventArgs e)
        {
            Användare A = vm.LoggaIn(AnvändarIDTxt.Text, LösenordTxt.Password);

            if (A == null)
            {
                MessageBox.Show("AnvändarIDt och lösenordet matchar inte","Error");
            }
            else
            {
                if (businessManager.InloggadPersonal != null)
                {
                    StartPersonal startPersonal = new StartPersonal(businessManager);
                    this.Hide();
                    startPersonal.ShowDialog();

                    businessManager.InloggadPersonal = null;
                    AnvändarIDTxt.Clear();
                    LösenordTxt.Clear();
                }
                else if (businessManager.InloggadAlumn != null)
                {
                    StartAnnan startAnnan = new StartAnnan(businessManager);
                    this.Hide();
                    startAnnan.ShowDialog();

                    businessManager.InloggadAlumn = null;
                    AnvändarIDTxt.Clear();
                    LösenordTxt.Clear();
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
