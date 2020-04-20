using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites
{
    public class Användare : Entity, IAnvändare, INotifyPropertyChanged
    {
        private string användarId;
        public string AnvändarId
        {
            get { return användarId; }
            set
            {
                användarId = value;
                Changed();
            }
        }

        private string lösenord;
        public string Lösenord
        {
            get { return lösenord; }
            set
            {
                lösenord = value;
                Changed();
            }
        }


        private string fNamn;
        public string FNamn
        {
            get { return fNamn; }
            set
            {
                fNamn = value;
                Changed();
            }
        }

        private string eNamn;
        public string ENamn
        {
            get { return eNamn; }
            set
            {
                eNamn = value;
                Changed();
            }
        }
        private string eMail;
        public string EMail
        {
            get { return eMail; }
            set
            {
                eMail = value;
                Changed();
            }
        }

        private int teleNr;
        public int TeleNr
        {
            get { return teleNr; }
            set
            {
                teleNr = value;
                Changed();
            }
        }


        public Användare()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
