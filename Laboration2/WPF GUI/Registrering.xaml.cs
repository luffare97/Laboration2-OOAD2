﻿using System;
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
    /// Interaction logic for Registrering.xaml
    /// </summary>
    public partial class Registrering : Window
    {
        public BusinessManager BusinessManager { get; }
        public Registrering(BusinessManager businessManager)
        {
            InitializeComponent();
            BusinessManager = businessManager;
        }
    }
}
