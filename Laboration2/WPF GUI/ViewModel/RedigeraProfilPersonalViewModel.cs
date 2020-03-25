using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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


        public void SparaInfo()
        {
            BusinessManager.RedigeraPersonal(Personal);
        }

        public void SparaLösen(string nytt)
        {
            BusinessManager.RedigeraLösenord(Personal.AnvändarId, nytt);
        }

        public void Tillbaka()
        {
            Personal = gammal;
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
