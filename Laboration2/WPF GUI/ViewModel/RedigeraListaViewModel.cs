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
    public class RedigeraListaViewModel : INotifyPropertyChanged
    {
        public BusinessManager BusinessManager { get; }
        public RedigeraListaViewModel(BusinessManager businessManager, UtskicksLista utskicksLista)
        {
            BusinessManager = businessManager;
            lista = utskicksLista;

            RaderaCmd = new RelayCommand(Radera, param => this.canExecute);
            SparaCmd = new RelayCommand(Spara, param => this.canExecute);
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

        private ICommand sparaCmd;
        public ICommand SparaCmd
        {
            get
            {
                return this.sparaCmd;
            }
            set
            {
                sparaCmd = value;
            }
        }


        private void Radera(object obj)
        {
            MessageBoxResult result = MessageBox.Show("Är du säker på att du vill radera den här listan?", "Radera?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                radera();
                MessageBox.Show("Ändringara har blivit Raderad", "Raderad");
                TillbakaAction();
            }
            else if (result == MessageBoxResult.No)
            {

            }
        }

        private void Spara(object obj)
        {
            MessageBoxResult result = MessageBox.Show("Är du säker på att du vill spara ändringarna?", "Spara?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                spara();
                MessageBox.Show("Ändringara har blivit sparade", "Sparat");
            }
            else if (result == MessageBoxResult.No)
            {

            }


        }

        private void Tillbaka(object obj)
        {
            TillbakaAction();
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

        public void radera()
        {
            BusinessManager.DeleteLista(lista.Id);
        }

        public void spara()
        {
            BusinessManager.RedigeraLista(Lista.Id, Lista.Titel, Lista.Information);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        

    }
}
