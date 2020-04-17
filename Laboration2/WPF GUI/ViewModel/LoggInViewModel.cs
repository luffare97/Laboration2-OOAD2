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

namespace WPF_GUI.ViewModel
{
    public class LoggInViewModel : INotifyPropertyChanged
    {
        public BusinessManager businessManager { get; }

        public LoggInViewModel()
        {
            //Update();
            businessManager = new BusinessManager();
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string användarId { get; set; }
        public string lösen { get; set; }

        public Användare LoggaIn(string ID, string Lösenord)
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


        public void LoggaIn()
        {
            Användare A = LoggaIn(användarId, lösen);

            if (A == null)
            {
                MessageBox.Show("AnvändarIDt och lösenorder matchar inte", "Error");
            }
            else if (A.Lösenord == lösen)
            {
                if ((A as Personal) != null)
                {
                    businessManager.InloggadPersonal = A as Personal;
                    StartPersonal startPersonal = new StartPersonal(businessManager);
                    //Close();
                    startPersonal.ShowDialog();

                }
                else if ((A as Alumn) != null)
                {
                    businessManager.InloggadAlumn = A as Alumn;
                    StartAnnan startAnnan = new StartAnnan(businessManager);
                    //this.Close();
                    startAnnan.ShowDialog();

                }
            }
        }

        private void Registrering()
        {
            Registrering registrering = new Registrering(businessManager);
            registrering.ShowDialog();
        }


    }
}
