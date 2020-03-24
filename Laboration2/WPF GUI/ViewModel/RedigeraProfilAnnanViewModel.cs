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
    public class RedigeraProfilAnnanViewModel : INotifyPropertyChanged
    {
        public BusinessManager BusinessManager { get; }
        public RedigeraProfilAnnanViewModel(BusinessManager businessManager)
        {
            BusinessManager = businessManager;

            alumn = BusinessManager.InloggadAlumn;
            gammal = BusinessManager.InloggadAlumn;
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
            BusinessManager.RedigeraLösenord(Alumn. AnvändarId, nytt);
        }

        public void Tillbaka()
        {
            Alumn = gammal;
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
