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
        }
    }
}
