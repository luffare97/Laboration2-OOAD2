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
    public class RedigeraProfilAnnanViewModel : INotifyPropertyChanged
    {
        public BusinessManager BusinessManager { get; }
        public RedigeraProfilAnnanViewModel(BusinessManager businessManager)
        {
            BusinessManager = businessManager;

            alumn = BusinessManager.InloggadAlumn;
            gammal = BusinessManager.InloggadAlumn;

            TillbakaCmd = new RelayCommand(Tillbaka, param => this.canExecute);
            SparaInfoCmd = new RelayCommand(RedigeraInfo, param => this.canExecute);
            SparaLösenCmd = new RelayCommand(RedigeraLösen, param => this.canExecute);
            RaderaCmd = new RelayCommand(Radera, param => this.canExecute);
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

        private ICommand sparaInfoCmd;
        public ICommand SparaInfoCmd
        {
            get
            {
                return sparaInfoCmd;
            }
            set
            {
                sparaInfoCmd = value;
            }
        }

        private ICommand sparaLösenCmd;
        public ICommand SparaLösenCmd
        {
            get
            {
                return sparaLösenCmd;
            }
            set
            {
                sparaLösenCmd = value;
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

        private void RedigeraInfo(object obj)
        {
            MessageBoxResult result = MessageBox.Show("Är du säker på att du vill spara de här ändringarna?", "Spara", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                SparaInfo();
                MessageBox.Show("Informationen har nu uppdaterats", "Sparat");
            }
            else if (result == MessageBoxResult.No)
            {

            }


        }

        private string nyttLösen;
        public string NyttLösen
        {
            get { return nyttLösen; }
            set
            {
                nyttLösen = value;
                Changed();
            }
        }

        private string upprepaLösen;
        public string UpprepaLösen
        {
            get { return upprepaLösen; }
            set
            {
                upprepaLösen = value;
                Changed();
            }
        }


        private string gammaltLösen;
        public string GammaltLösen
        {
            get { return gammaltLösen; }
            set
            {
                gammaltLösen = value;
                Changed();
            }
        }


        private void RedigeraLösen(object obj)
        {

            if (BusinessManager.InloggadAlumn.Lösenord == GammaltLösen)
            {
                if (NyttLösen == UpprepaLösen)
                {
                    string nytt = NyttLösen;
                    SparaLösen(nytt);
                    MessageBox.Show("Ditt nya löseord har nu sparats", "Sparat");
                    
                }
                else
                {
                    MessageBox.Show("Nya lösenord stämmer inte överrens", "Error");
                }
            }
            else
            {
                MessageBox.Show("Fel gammalt lösenord", "Error");
            }

        }

        private void Radera(object obj)
        {
            RaderaKonto radera = new RaderaKonto(BusinessManager);
            radera.ShowDialog();
            if (BusinessManager.OK == true)
            {                
                TillbakaAction();
            }
            else if (BusinessManager.OK == false)
            {
                
            }
        }


        private void Tillbaka(object obj)
        {
            BusinessManager.OK = false;
            BusinessManager.InloggadAlumn = gammal;
            TillbakaAction();
            
        }

        public Alumn gammal { get; set; }

        private Alumn alumn = new Alumn();

        public Alumn Alumn
        {
            get { return alumn; }
            set
            {
                alumn = value;
                Changed();

            }
        }

        public void SparaInfo()
        {
            BusinessManager.RedigeraAlumn(Alumn);
        }

        public void SparaLösen(string nytt)
        {
            BusinessManager.RedigeraLösenord(Alumn.AnvändarId, nytt);
        }




        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
