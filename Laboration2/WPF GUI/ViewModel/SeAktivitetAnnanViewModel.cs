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
    public class SeAktivitetAnnanViewModel : INotifyPropertyChanged
    {
        public BusinessManager BusinessManager { get; }
        public SeAktivitetAnnanViewModel(BusinessManager businessManager, Aktivitet A)
        {
            BusinessManager = businessManager;
            aktivitet = A;

            DeltaCmd = new RelayCommand(Delta, param => this.canExecute);
            TillbakaCmd = new RelayCommand(Tillbaka, param => this.canExecute);
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

        private ICommand deltaCmd;
        public ICommand DeltaCmd
        {
            get
            {
                return deltaCmd;
            }
            set
            {
                deltaCmd = value;
            }
        }


        private void Delta(object obj)
        {
            MessageBoxResult result = MessageBox.Show("Vill du Delta i den här aktiviteten?", "Är du säker?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                delta();
                MessageBox.Show("Du kommer nu att delta i den här aktiviteten", "Yay");
            }
            else
            {

            }

        }

        private void Tillbaka(object obj)
        {
            StartAnnan start = new StartAnnan(BusinessManager);
            TillbakaAction();
            start.ShowDialog();

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

        public void delta()
        {
            Alumn A = BusinessManager.GetAlumn(BusinessManager.InloggadAlumn.AnvändarId);
            BusinessManager.DeltaAktivitet(aktivitet.Id, A);
        }





        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
