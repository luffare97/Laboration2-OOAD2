using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites
{
    public class UtskicksLista : Entity, IUtskicksLista, INotifyPropertyChanged
    {

        private string information;
        public string Information
        {
            get { return information; }
            set
            {
                information = value;
                Changed();
            }
        }

        private string titel;
        public string Titel
        {
            get { return titel; }
            set
            {
                titel = value;
                Changed();
            }
        }

        private ObservableCollection<Alumn> mottagare;
        public ObservableCollection<Alumn> Mottagare
        {
            get { return mottagare; }
            set
            {
                mottagare = value;
                Changed();
            }
        }

        public UtskicksLista()
        {
            Mottagare = new ObservableCollection<Alumn>();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
