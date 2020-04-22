using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using BusinessEntites;
using BusinessLayer;

namespace WPF_GUI.ViewModel
{
    public class GDPRViewModel : INotifyPropertyChanged
    {

        public BusinessManager BusinessManager { get; }


        public GDPRViewModel(BusinessManager businessManager)
        {
            BusinessManager = businessManager;
            BusinessManager.OK = false;
            TillbakaCmd = new RelayCommand(GodkännerInte, param => this.canExecute);
            GodkännerCmd = new RelayCommand(Godkänner, param => this.canExecute);

        }
       

        public Action TillbakaAction { get; set; }

        private bool canExecute = true;
        public bool CanExecute
        {
            get
            {
                return this.canExecute;
            }
            set
            {
                if (this.canExecute == value)
                {
                    return;
                }
                this.canExecute = value;
            }
        }

        private ICommand tillbakaCmd;
        public ICommand TillbakaCmd
        {
            get
            {
                return tillbakaCmd;
            }
            set
            {
                tillbakaCmd = value;
            }
        }

        private ICommand godkännerCmd;
        public ICommand GodkännerCmd
        {
            get
            {
                return godkännerCmd;
            }
            set
            {
                godkännerCmd = value;
            }
        }

        private bool checkbox;
        public bool Checkbox
        {
            get { return checkbox; }
            set
            {
                checkbox = value;
                Changed();
            }
        }


        private void Godkänner(object obj)
        {
            
            if (Checkbox == true)
            {
                BusinessManager.OK = true;
                TillbakaAction();
            }
            else if(Checkbox == false)
            {
                BusinessManager.OK = false;
                MessageBox.Show("Du måste godkänna villkoren för att kunna skapa ett konto", "Fel");

            }
        }

        private void GodkännerInte(object obj)
        {
            BusinessManager.OK = false;
            TillbakaAction();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
