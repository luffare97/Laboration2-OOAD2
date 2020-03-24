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
    public class RaderaKontoViewModel : INotifyPropertyChanged
    {
        public BusinessManager BusinessManager { get; }
        public RaderaKontoViewModel(BusinessManager businessManager)
        {
            BusinessManager = businessManager;

        }

        public void Radera()
        {
            BusinessManager.DeleteAlumn(BusinessManager.InloggadAlumn.AnvändarId);
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
