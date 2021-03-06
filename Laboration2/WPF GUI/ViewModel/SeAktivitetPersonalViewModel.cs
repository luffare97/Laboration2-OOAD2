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
using System.Data.Entity;

namespace WPF_GUI.ViewModel
{
    public class SeAktivitetPersonalViewModel : INotifyPropertyChanged
    {
        public BusinessManager BusinessManager { get; }
        public SeAktivitetPersonalViewModel(BusinessManager businessManager, Aktivitet A)
        {
            BusinessManager = businessManager;
            Aktivitet = BusinessManager.GetAktivitet(A.Id);


            FyllLB();
            //Hämtade = businessManager.GetAlumnForAktivitet(A);
            //TEST();

            TillbakaCmd = new RelayCommand(Tillbaka, param => this.canExecute);
            RedigeraCmd = new RelayCommand(Redigera, param => this.canExecute);



        }


        public void FyllLB()
        {
            //Alumner = BusinessManager.GetAlumnForAktivitet(Aktivitet);

            ICollection<Alumn> Hämtade = BusinessManager.GetAlumnForAktivitet(Aktivitet);
            foreach (Alumn a in Hämtade)
            {
                Alumner.Add(a);
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

        private ICollection<Alumn> hämtade;

        public ICollection<Alumn> Hämtade
        {
            get { return hämtade; }
            set { hämtade = value;
                Changed();
            }
        }




        public ObservableCollection<Alumn> alumner = new ObservableCollection<Alumn>();
        private ObservableCollection<Alumn> Alumner
        {
            get { return alumner; }
            set
            {
                alumner = value;
                Changed();
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
