using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites
{
    public class Personal : Användare, IPersonal, INotifyPropertyChanged
    {
        private string possition;
        public string Possition
        {
            get { return possition; }
            set
            {
                possition = value;
                Changed();
            }
        }


        public Personal()
        {

        }

        public Aktivitet skapaAktivitet()
        {
            Aktivitet A = new Aktivitet();

            return A;
        }

        //public event PropertyChangedEventHandler PropertyChanged;
        //public void Changed([CallerMemberName] String propertyName = "")
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

    }
}
