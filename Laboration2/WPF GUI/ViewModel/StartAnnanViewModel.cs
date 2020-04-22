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
    
    public class StartAnnanViewModel : INotifyPropertyChanged
    {


        public BusinessManager BusinessManager { get; }
        public StartAnnanViewModel(BusinessManager businessManager)
        {
            BusinessManager = businessManager;

            LoggUtCommand = new RelayCommand(LoggaUt, param => this.canExecute);
            RedigeringCommand = new RelayCommand(RedigeraProfil, param => this.canExecute);
            VäljAktivitetCMD = new RelayCommand(VäljAktivitet, param => this.canExecute);
            VäljListaCMD = new RelayCommand(VäljLista, param => this.canExecute);



            Alumn = BusinessManager.GetAlumn(businessManager.InloggadAlumn.AnvändarId);

            //Listor = Alumn.Listor;

            //Aktiviteter = BusinessManager.GetAllAktiviteter();
            
            UpdateGrids();
            
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


        public void UpdateGrids()
        {
            //foreach (UtskicksLista u in Alumn.Listor)
            //{
            //    //UtskicksLista l = BusinessManager.GetUtskicksLista(u.Id);
            //    Listor.Add(BusinessManager.GetUtskicksLista(u.Id));

            //}

            foreach (UtskicksLista u in BusinessManager.GetAllListor())
            {
                foreach (Alumn a in u.Mottagare)
                {
                    if (a.AnvändarId == Alumn.AnvändarId)
                    {
                        Listor.Add(u);
                    }
                }
            }

            foreach (Aktivitet a in BusinessManager.GetAllAktiviteter())
            {
                Aktiviteter.Add(a);

            }
        }

        private Alumn alumn;
        public Alumn Alumn
        {
            get { return alumn; }
            set
            {
                alumn = value;
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



        private void RedigeraProfil(object obj)
        {
            RedigeraProfilAnnan RedigeraProfil = new RedigeraProfilAnnan(BusinessManager);
            RedigeraProfil.ShowDialog();

            if (BusinessManager.OK == true)
            {
                MainWindow loggIn = new MainWindow();
                TillbakaAction();
                loggIn.ShowDialog();
            }
            else if (BusinessManager.OK == false)
            {

            }
        }

        private void LoggaUt(object obj)
        {
            MainWindow loggIn = new MainWindow();
            TillbakaAction();
            loggIn.ShowDialog();
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
                SeUtskicksListaAnnan seUtskicksLista = new SeUtskicksListaAnnan(BusinessManager, ValdLista);
                TillbakaAction();
                seUtskicksLista.ShowDialog();
            }

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
                SeAktivitetAnnan seAktivitet = new SeAktivitetAnnan(BusinessManager, ValdAktivitet);
                TillbakaAction();

                seAktivitet.ShowDialog();
            }

        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }



}
