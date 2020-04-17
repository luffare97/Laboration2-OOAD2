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
    public class Alumn : Användare, IAlumn, INotifyPropertyChanged
    {
        private string ort;

        public string Ort
        {
            get { return ort; }
            set
            {
                ort = value;
                Changed();
            }
        }

        private string anställning;
        public string Anställning
        {
            get { return anställning; }
            set
            {
                anställning = value;
                Changed();
            }
        }


        private Utbildning program;
        public Utbildning Program
        {
            get { return program; }
            set
            {
                program = value;
                Changed();
            }
        }


        private ObservableCollection<UtskicksLista> listor;
        public ObservableCollection<UtskicksLista> Listor
        {
            get { return listor; }
            set
            {
                listor = value;
                Changed();
            }
        }

        private ObservableCollection<Aktivitet> aktiviteter;
        public ObservableCollection<Aktivitet> Aktiviteter
        {
            get { return aktiviteter; }
            set
            {
                aktiviteter = value;
                Changed();
            }
        }

        private int examensÅr;
        public int ExamensÅr
        {
            get { return examensÅr; }
            set
            {
                examensÅr = value;
                Changed();
            }
        }


        public Alumn()
        {
            Listor = new ObservableCollection<UtskicksLista>();
            Aktiviteter = new ObservableCollection<Aktivitet>();
        }

        public override string ToString()
        {
            return AnvändarId + " " + FNamn + " " + ENamn;
        }

        //public event PropertyChangedEventHandler PropertyChanged;
        //public void Changed([CallerMemberName] String propertyName = "")
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

    }
}
