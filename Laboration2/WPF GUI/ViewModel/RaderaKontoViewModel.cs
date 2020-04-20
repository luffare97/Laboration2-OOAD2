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
    public class RaderaKontoViewModel : INotifyPropertyChanged
    {
        public BusinessManager BusinessManager { get; }
        public RaderaKontoViewModel(BusinessManager businessManager)
        {
            BusinessManager = businessManager;
            TillbakaCmd = new RelayCommand(Tillbaka, param => this.canExecute);
            RaderaCmd = new RelayCommand(Radera, param => this.canExecute);
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
                return this.tillbakaCmd;
            }
            set
            {
                tillbakaCmd = value;
            }
        }

        private string lösen1;
        public string Lösen1
        {
            get { return lösen1; }
            set
            {
                lösen1 = value;
                Changed();
            }
        }

        private string lösen2;
        public string Lösen2
        {
            get { return lösen2; }
            set
            {
                lösen2 = value;
                Changed();
            }
        }

        private void Radera(object obj)
        {
            if (Lösen1 == Lösen2)
            {
                if (Lösen1 == BusinessManager.InloggadAlumn.Lösenord)
                {
                    MessageBoxResult result = MessageBox.Show("Är du säker på att du vill ta bort kontot?", "Är du säker?", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        radera();
                        MessageBox.Show("Ditt konto har nu raderats och du kommer att tas tillbaka till loggin skärmen", "Raderat");
                        //this.DialogResult = true;
                    }
                    else if (result == MessageBoxResult.No)
                    {
                        //this.DialogResult = false;
                    }

                }
                else
                {
                    MessageBox.Show("Fel lösenord", "Error");
                }
            }
            else
            {
                MessageBox.Show("Lösenorden matchade inte", "Error");
            }

        }

        private void Tillbaka(object obj)
        {
            //this.DialogResult = false;
            TillbakaAction();
        }

        public void radera()
        {
            BusinessManager.DeleteAlumn(BusinessManager.InloggadAlumn.AnvändarId);
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
