using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessEntites;
using System.Windows;
using System.Windows.Input;

namespace WPF_GUI.ViewModel
{
    public class LoggInViewModel : INotifyPropertyChanged
    {
        public BusinessManager businessManager { get; }

        public LoggInViewModel()
        {
            //Update();
            businessManager = new BusinessManager();
            LoggInCommand = new RelayCommand(LoggaIn, param => this.canExecute);
            RegistreringCommand = new RelayCommand(Registrering, param => this.canExecute);
            
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

        private ICommand loggInCommand;
        public ICommand LoggInCommand
        {
            get
            {
                return loggInCommand;
            }
            set
            {
                loggInCommand = value;
            }
        }

        private ICommand registreringCommand;
        public ICommand RegistreringCommand
        {
            get
            {
                return this.registreringCommand;
            }
            set
            {
                registreringCommand = value;
            }
        }



        private string användarId;
        public string AnvändarId
        {
            get { return användarId; }
            set
            {
                användarId = value;
                Changed();
            }
        }

        private string lösen;
        public string Lösen
        {
            get { return lösen; }
            set
            {
                lösen = value;
                Changed();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        

        public Användare loggaIn(string ID, string Lösenord)
        {

            Användare A = businessManager.LoggaIn(ID, Lösenord);

            if (A == null)
            {

            }
            else
            {
                if ((A as Personal) != null)
                {
                    businessManager.InloggadPersonal = A as Personal;
                }
                else if ((A as Alumn) != null)
                {
                    businessManager.InloggadAlumn = A as Alumn;
                }
            }

            return A;

        }


        public void LoggaIn(object obj)
        {
            
            Användare A = loggaIn(användarId, Lösen);

            if (A == null)
            {
                MessageBox.Show("AnvändarIDt och lösenorder matchar inte", "Error");
            }
            else if (A.Lösenord == Lösen)
            {
                if ((A as Personal) != null)
                {
                    businessManager.InloggadPersonal = A as Personal;
                    StartPersonal startPersonal = new StartPersonal(businessManager);
                    TillbakaAction();
                    startPersonal.ShowDialog();

                }
                else if ((A as Alumn) != null)
                {
                    businessManager.InloggadAlumn = A as Alumn;
                    StartAnnan startAnnan = new StartAnnan(businessManager);
                    TillbakaAction();
                    startAnnan.ShowDialog();

                }
            }
        }



        private void Registrering(object obj)
        {
            Registrering registrering = new Registrering(businessManager);
            registrering.ShowDialog();
        }


    }
}
