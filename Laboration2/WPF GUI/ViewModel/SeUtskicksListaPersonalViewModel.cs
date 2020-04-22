using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BusinessEntites;
using BusinessLayer;

namespace WPF_GUI.ViewModel
{
    public class SeUtskicksListaPersonalViewModel : INotifyPropertyChanged
    {
        public BusinessManager BusinessManager { get; }
        public SeUtskicksListaPersonalViewModel(BusinessManager businessManager, UtskicksLista utskicksLista)
        {
            BusinessManager = businessManager;
            lista = BusinessManager.GetUtskicksLista(utskicksLista.Id);

            TillbakaCmd = new RelayCommand(Tillbaka, param => this.canExecute);
            RedigeraCmd = new RelayCommand(Redigera, param => this.canExecute);

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


        private void Redigera(object obj)
        {
            RedigeraLista redigera = new RedigeraLista(BusinessManager, Lista);
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


        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
