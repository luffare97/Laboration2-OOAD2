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
    public class NyAktivitetViewModel : INotifyPropertyChanged
    {
        public BusinessManager BusinessManager { get; }
        public NyAktivitetViewModel(BusinessManager businessManager)
        {
            BusinessManager = businessManager;
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
            MessageBoxResult result = MessageBox.Show("Vill du spara aktiviteten såhär?", "Spara?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                spara();
                StartPersonal start = new StartPersonal(BusinessManager);
                TillbakaAction();
                start.ShowDialog();
            }
            else
            {

            }

        }

        private void Tillbaka(object obj)
        {
            StartPersonal start = new StartPersonal(BusinessManager);
            TillbakaAction();
            start.ShowDialog();
        }


        public void spara()
        {
            BusinessManager.CreateAktivitet(Aktivitet);
        }




        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
