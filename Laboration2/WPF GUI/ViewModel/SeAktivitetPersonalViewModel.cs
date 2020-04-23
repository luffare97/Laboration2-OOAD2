using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public class SeAktivitetPersonalViewModel : INotifyPropertyChanged
    {
        public BusinessManager BusinessManager { get; }
        public SeAktivitetPersonalViewModel(BusinessManager businessManager, Aktivitet A)
        {
            BusinessManager = businessManager;
            Aktivitet = A;
            Alumner = FyllLB(A);

            TillbakaCmd = new RelayCommand(Tillbaka, param => this.canExecute);
            RedigeraCmd = new RelayCommand(Redigera, param => this.canExecute);



            CheckCmd = new RelayCommand(Check, param => this.canExecute);

        }

        public void Check(object obj)
        {
            MessageBox.Show($"Aktiviteten har {Aktivitet.Deltagare.Count} deltagare","check");
        }

        private ICommand checkCmd;
        public ICommand CheckCmd
        {
            get
            {
                return checkCmd;
            }
            set
            {
                checkCmd = value;
            }
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

        private ICommand redigeraCmd;
        public ICommand RedigeraCmd
        {
            get
            {
                return redigeraCmd;
            }
            set
            {
                redigeraCmd = value;
            }
        }


        public ObservableCollection<Alumn> FyllLB(Aktivitet A)
        {
            return BusinessManager.GetAlumnForAktivitet(A.Id);
        }

        public ObservableCollection<Alumn> alumner = new ObservableCollection<Alumn>();
        private ObservableCollection<Alumn> Alumner
        {
            get { return alumner; }
            set
            {
                alumner = value;

            }
        }


        private void Redigera(object obj)
        {
            RedigeraAktivitet redigera = new RedigeraAktivitet(BusinessManager, Aktivitet);
            redigera.ShowDialog();

            if (redigera.DialogResult == true)
            {
                StartPersonal start = new StartPersonal(BusinessManager);
                TillbakaAction();
                start.ShowDialog();

            }
            else if (redigera.DialogResult == false)
            {

            }
        }

        private void Tillbaka(object obj)
        {
            StartPersonal start = new StartPersonal(BusinessManager);
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


        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
