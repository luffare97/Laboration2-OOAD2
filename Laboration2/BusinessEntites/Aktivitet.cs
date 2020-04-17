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
    public class Aktivitet : Entity, IAktivitet, INotifyPropertyChanged
    {

        private string aktivitetNamn;
        public string AktivitetNamn
        {
            get { return aktivitetNamn; }
            set
            {
                aktivitetNamn = value;
                Changed();
            }
        }

        private DateTime datum;
        public DateTime Datum
        {
            get { return datum; }
            set
            {
                datum = value;
                Changed();
            }
        }

        private string tid;
        public string Tid
        {
            get { return tid; }
            set
            {
                tid = value;
                Changed();
            }
        }


        private string antalPlatser;
        public string AntalPlatser
        {
            get { return antalPlatser; }
            set
            {
                antalPlatser = value;
                Changed();
            }
        }

        private string plats;
        public string Plats
        {
            get { return plats; }
            set
            {
                plats = value;
                Changed();
            }
        }

        private string beskrivning;
        public string Beskrivning
        {
            get { return beskrivning; }
            set
            {
                beskrivning = value;
                Changed();
            }
        }

        private ObservableCollection<Alumn> deltagare;
        public ObservableCollection<Alumn> Deltagare
        {
            get { return deltagare; }
            set
            {
                deltagare = value;
                Changed();
            }
        }

        public Aktivitet()
        {
            Deltagare = new ObservableCollection<Alumn>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
