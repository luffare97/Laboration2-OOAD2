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
    public class RedigeraProfilPersonalViewModel : INotifyPropertyChanged
    {
        public BusinessManager BusinessManager { get; }
        public RedigeraProfilPersonalViewModel(BusinessManager businessManager)
        {
            BusinessManager = businessManager;

            Personal = BusinessManager.InloggadPersonal;
            gammal = BusinessManager.InloggadPersonal;

            TillbakaCmd = new RelayCommand(Tillbaka, param => this.canExecute);
            SparaInfoCmd = new RelayCommand(RedigeraInfo, param => this.canExecute);
            RaderaCmd = new RelayCommand(Radera, param => this.canExecute);
            SparaLösenCmd = new RelayCommand(RedigeraLösen, param => this.canExecute);

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


        private void RedigeraInfo(object obj)
        {

            sparaInfo();
            MessageBox.Show("Informationen har nu uppdaterats", "Sparat");
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


        private void RedigeraLösen(object obj)
        {

            if (BusinessManager.InloggadPersonal.Lösenord == GammaltLösen)
            {
                if (NyttLösen == UpprepaLösen)
                {
                    string nytt = NyttLösen;
                    sparaLösen(nytt);
                    MessageBox.Show("Ditt nya löseord har nu sparats", "Sparat");
                    //GammaltLösen.Clear();
                    //NyttLösen.Clear();
                    //UpprepaLösen.Clear();
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
            if (radera.DialogResult == true)
            {
                //this.DialogResult = true;
                TillbakaAction();
            }
            else if (radera.DialogResult == false)
            {
                //this.DialogResult = false;
            }
        }

        private void Tillbaka(object obj)
        {
            //this.DialogResult = false;
            Personal = gammal;
            TillbakaAction();
            //this.Close();

        }

        public Personal gammal { get; set; }


        private Personal personal = new Personal();
        public Personal Personal
        {
            get { return personal; }
            set
            {
                personal = value;
                Changed();
            }
        }


        public void sparaInfo()
        {
            BusinessManager.RedigeraPersonal(Personal);
        }

        public void sparaLösen(string nytt)
        {
            BusinessManager.RedigeraLösenord(Personal.AnvändarId, nytt);
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
