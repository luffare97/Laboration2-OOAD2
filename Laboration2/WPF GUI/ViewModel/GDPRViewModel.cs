using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites;
using BusinessLayer;

namespace WPF_GUI.ViewModel
{
    public class GDPRViewModel : INotifyPropertyChanged
    {

        //private void Godkänner()
        //{
        //    if (GodkäntBox.IsChecked == true)
        //    {
        //        this.DialogResult = true;
        //        this.Close();
        //    }
        //    else
        //    {
        //        this.DialogResult = false;
        //        MessageBox.Show("Du måste godkänna villkoren för att kunna skapa ett konto", "Fel");
        //    }
        //}

        //private void GodkännerInte()
        //{
        //    this.DialogResult = false;
        //    this.Close();
        //}

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
