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
    public class RedigeraAktivitetViewModel : INotifyPropertyChanged
    {
        public BusinessManager BusinessManager { get; }
        public RedigeraAktivitetViewModel(BusinessManager businessManager, Aktivitet A)
        {
            BusinessManager = businessManager;
            aktivitet = A;

            RaderaCmd = new RelayCommand(Radera, param => this.canExecute);
            TillbakaCmd = new RelayCommand(Tillbaka, param => this.canExecute);
            SparaCmd = new RelayCommand(Spara, param => this.canExecute);

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

        private ICommand raderaCmd;
        public ICommand RaderaCmd
        {
            get
            {
                return raderaCmd;
            }
            set
            {
                raderaCmd = value;
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

        private ICommand sparaCmd;
        public ICommand SparaCmd
        {
            get
            {
                return sparaCmd;
            }
            set
            {
                sparaCmd = value;
            }
        }


        private Aktivitet aktivitet = new Aktivitet();
        public Aktivitet Aktivitet
        {
            get { return aktivitet; }
            set
            {
                aktivitet = value;
                Changed();
            }
        }


        private void Spara(object obj)
        {
            MessageBoxResult result = MessageBox.Show("Är du säker på att du vill spara ändringarna?", "Är du säker?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                spara();
                //this.DialogResult = false;
            }
            else if (result == MessageBoxResult.No)
            {
                //this.DialogResult = false;
            }

        }

        private void Radera(object obj)
        {
            MessageBoxResult result = MessageBox.Show("Är du säker på att du vill radera den här aktiviteten?", "Är du säker?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                radera();
                //this.DialogResult = true;
            }
            else if (result == MessageBoxResult.No)
            {
                //this.DialogResult = false;
            }


        }

        private void Tillbaka(object obj)
        {
            //this.DialogResult = false;
            TillbakaAction();
        }


        public void spara()
        {
            BusinessManager.RedigeraAktivitet(Aktivitet.Id, Aktivitet);
        }

        public void radera()
        {
            BusinessManager.DeleteAktivitet(Aktivitet.Id);
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
