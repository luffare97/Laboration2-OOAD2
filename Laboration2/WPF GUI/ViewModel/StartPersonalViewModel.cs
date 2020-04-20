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
using static System.Net.Mime.MediaTypeNames;

namespace WPF_GUI.ViewModel
{
    public class StartPersonalViewModel : INotifyPropertyChanged
    {
        public BusinessManager BusinessManager { get; }
        public StartPersonalViewModel(BusinessManager businessManager)
        {
            BusinessManager = businessManager;

            LoggUtCommand = new RelayCommand(LoggaUt, param => this.canExecute);
            RedigeringCommand = new RelayCommand(RedigeraProfil, param => this.canExecute);
            VäljAktivitetCMD = new RelayCommand(VäljAktivitet, param => this.canExecute);
            NyAktivitetCMD = new RelayCommand(SkapaAktivitet, param => this.canExecute);
            VäljListaCMD = new RelayCommand(VäljLista, param => this.canExecute);
            NyListaCMD = new RelayCommand(SkapaLista, param => this.canExecute);

            personal = BusinessManager.InloggadPersonal;

            
            FyllGrids();

            
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

        private ICommand loggUtCommand;
        public ICommand LoggUtCommand
        {
            get
            {
                return loggUtCommand;
            }
            set
            {
                loggUtCommand = value;
            }
        }

        private ICommand redigeringCommand;
        public ICommand RedigeringCommand
        {
            get
            {
                return this.redigeringCommand;
            }
            set
            {
                redigeringCommand = value;
            }
        }

        private ICommand väljAktivitetCMD;
        public ICommand VäljAktivitetCMD
        {
            get
            {
                return this.väljAktivitetCMD;
            }
            set
            {
                väljAktivitetCMD = value;
            }
        }

        private ICommand nyAktivitetCMD;
        public ICommand NyAktivitetCMD
        {
            get
            {
                return this.nyAktivitetCMD;
            }
            set
            {
                nyAktivitetCMD = value;
            }
        }

        private ICommand väljListaCMD;
        public ICommand VäljListaCMD
        {
            get
            {
                return this.väljListaCMD;
            }
            set
            {
                väljListaCMD = value;
            }
        }

        private ICommand nyListaCMD;
        public ICommand NyListaCMD
        {
            get
            {
                return this.nyListaCMD;
            }
            set
            {
                nyListaCMD = value;
            }
        }


        public void FyllGrids()
        {
            ICollection<UtskicksLista> L = BusinessManager.GetAllListor();

            foreach (UtskicksLista l in L)
            {
                Listor.Add(l);
            }

            ICollection<Aktivitet> A = BusinessManager.GetAllAktiviteter();

            foreach (Aktivitet a in A)
            {
                Aktiviteter.Add(a);
            }
        }


        private Personal personal = new Personal();
        public Personal Personal
        {
            get { return personal; }
            set
            {
                personal = value;

            }
        }


        private ObservableCollection<UtskicksLista> listor = new ObservableCollection<UtskicksLista>();
        public ObservableCollection<UtskicksLista> Listor
        {
            get { return listor; }
            set
            {
                listor = value;
                Changed();
            }
        }


        private UtskicksLista lista;
        public UtskicksLista Lista
        {
            get { return lista; }
            set
            {
                lista = value;
                Changed();
            }
        }


        private ObservableCollection<Aktivitet> aktiviteter = new ObservableCollection<Aktivitet>();
        public ObservableCollection<Aktivitet> Aktiviteter
        {
            get { return aktiviteter; }
            set
            {
                aktiviteter = value;
                Changed();
            }
        }


        private Aktivitet aktivitet;
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


        private void RedigeraProfil(object obj)
        {
            RedigeraProfilPersonal RedigeraProfil = new RedigeraProfilPersonal(BusinessManager);

            RedigeraProfil.ShowDialog();
        }


        private void LoggaUt(object obj)
        {
            MainWindow loggIn = new MainWindow();
            TillbakaAction();
            loggIn.ShowDialog();
        }

        private void SkapaLista(object obj)
        {
            NyUtskicksLista NyLista = new NyUtskicksLista(BusinessManager);
            TillbakaAction();
            NyLista.ShowDialog();
        }

        private void VäljLista(object obj)
        {

            if (Lista == null)
            {
                MessageBox.Show("Du har inte valt en lista", "Error");
            }
            else
            {
                UtskicksLista ValdLista = (UtskicksLista)Lista;

                SeUtskicksListaPersonal seUtskicksLista = new SeUtskicksListaPersonal(BusinessManager, ValdLista);
                TillbakaAction();

                seUtskicksLista.ShowDialog();
            }

        }

        private void SkapaAktivitet(object obj)
        {
            NyAktivitet nyAktivitet = new NyAktivitet(BusinessManager);
            TillbakaAction();
            nyAktivitet.ShowDialog();
        }

        private void VäljAktivitet(object obj)
        {

            if (Aktivitet == null)
            {
                MessageBox.Show("Du har inte valt en aktivitet", "Error");
            }
            else
            {
                Aktivitet ValdAktivitet = (Aktivitet)Aktivitet;

                SeAktivitetPersonal seAktivitet = new SeAktivitetPersonal(BusinessManager, Aktivitet);
                TillbakaAction();
                seAktivitet.ShowDialog();
            }

        }

    }


    
}
