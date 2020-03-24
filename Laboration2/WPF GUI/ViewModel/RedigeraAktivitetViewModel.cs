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
    public class RedigeraAktivitetViewModel : INotifyPropertyChanged
    {
        public BusinessManager BusinessManager { get; }
        public RedigeraAktivitetViewModel(BusinessManager businessManager, Aktivitet A)
        {
            BusinessManager = businessManager;
            aktivitet = A;

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


        public void Spara()
        {
            BusinessManager.RedigeraAktivitet(aktivitet.Id, aktivitet);
        }

        public void Radera()
        {
            BusinessManager.DeleteAktivitet(aktivitet.Id);
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
