using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites;
using BusinessLayer;

namespace WPF_GUI.ViewModel
{
    public class RegistreringViewModel : INotifyPropertyChanged
    {

        public BusinessManager BusinessManager { get; }
        public RegistreringViewModel(BusinessManager businessManager)
        {
            BusinessManager = businessManager;

        }

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

        public void Spara()
        {   
            BusinessManager.CreateAlumn(Alumn);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
