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
    public class SeUtskicksListaAnnanViewModel : INotifyPropertyChanged
    {
        public BusinessManager BusinessManager { get; }
        public SeUtskicksListaAnnanViewModel(BusinessManager businessManager, UtskicksLista utskicksLista)
        {
            BusinessManager = businessManager;
            lista = utskicksLista;

            SlutaFöljaCmd = new RelayCommand(SlutaFölja, param => this.canExecute);
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

        private ICommand slutaFöljaCmd;
        public ICommand SlutaFöljaCmd
        {
            get
            {
                return slutaFöljaCmd;
            }
            set
            {
                slutaFöljaCmd = value;
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


        private void SlutaFölja(object obj)
        {
            MessageBoxResult result = MessageBox.Show("Vill du sluta följa listan?", "Är du säker?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                slutaFölja();
                StartAnnan start = new StartAnnan(BusinessManager);
                TillbakaAction();
                start.ShowDialog();
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

        public void slutaFölja()
        {
            BusinessManager.RemoveMottagare(Lista.Id, BusinessManager.InloggadAlumn);
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
