﻿using System;
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

    public class NyUtskicksListaViewModel : INotifyPropertyChanged
    {
        public BusinessManager BusinessManager { get; }

        public NyUtskicksListaViewModel(BusinessManager businessManager)
        {
            BusinessManager = businessManager;
            FyllLB();
            TillbakaCmd = new RelayCommand(Tillbaka, param => this.canExecute);
            LäggTillCmd = new RelayCommand(LäggTill, param => this.canExecute);
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

        private ICommand läggTillCmd;
        public ICommand LäggTillCmd
        {
            get
            {
                return this.läggTillCmd;
            }
            set
            {
                läggTillCmd = value;
            }
        }


        public void FyllLB()
        {
            ICollection<Alumn> A = BusinessManager.GetAllAlumn();

            foreach (Alumn a in A)
            {
                Alumner.Add(a);
            }
        }


        private ObservableCollection<Alumn> alumner = new ObservableCollection<Alumn>();
        public ObservableCollection<Alumn> Alumner
        {
            get { return alumner; }
            set
            {
                alumner = value;
                Changed();
            }
        }

        private Alumn valdAlumn;
        public Alumn ValdAlumn
        {
            get { return valdAlumn; }
            set
            {
                valdAlumn = value;
                Changed();
            }
        }


        private UtskicksLista lista = new UtskicksLista();
        public UtskicksLista Lista
        {
            get { return lista; }
            set
            {
                lista = value;
                Changed();
            }
        }

        //private ObservableCollection<Alumn> selectListBox = new ObservableCollection<Alumn>();
        //public ObservableCollection<Alumn> SelectListBox
        //{
        //    get { return selectListBox; }
        //    set
        //    {
        //        selectListBox = value;
        //        Changed();
        //    }
        //}

        private void LäggTill(object obj)
        {
            
            Lista.Mottagare.Add(BusinessManager.GetAlumn(ValdAlumn.AnvändarId));
            Alumner.Remove(ValdAlumn);
        }

        private void Spara(object obj)
        {
            MessageBoxResult result = MessageBox.Show("Vill du spara Utskickslistan såhär?", "Spara?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                //ObservableCollection<Alumn> A = new ObservableCollection<Alumn>();

                //foreach (Alumn a in SelectListBox)
                //{
                //    Alumn alumn = BusinessManager.GetAlumn(a.AnvändarId);
                //    A.Add(alumn);
                //}

                //Alumner = A;
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
            //Lista.Mottagare = SelectListBox;
            //foreach (Alumn a in Lista.Mottagare)
            //{
            //    BusinessManager.GetAlumn(a.AnvändarId).Listor.Add(Lista);
                
            //}

            BusinessManager.CreateList(Lista);
        }




        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
