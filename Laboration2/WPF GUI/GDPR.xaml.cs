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
    /// Interaction logic for GDPR.xaml
    /// </summary>
    public partial class GDPR : Window
    {
        public GDPRViewModel vm { get; set; }
        public BusinessManager BusinessManager { get; }
        public GDPR(BusinessManager businessManager)
        {
            InitializeComponent();
            vm = new GDPRViewModel();
            BusinessManager = businessManager;
        }

        //private void Godkänner(object sender, RoutedEventArgs e)
        //{
        //    if (GodkäntBox.IsChecked == true)
        //    {
        //        this.DialogResult = true;
        //        this.Close();
        //    }
        //    else
        //    {
        //        this.DialogResult = false;
        //        MessageBox.Show("Du måste godkänna villkoren för att kunna skapa ett konto","Fel");
        //    }
        //}

        //private void GodkännerInte(object sender, RoutedEventArgs e)
        //{
        //    this.DialogResult = false;
        //    this.Close();
        //}
    }
}
