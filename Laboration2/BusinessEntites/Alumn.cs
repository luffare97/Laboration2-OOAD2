using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessEntites
{
    public class Alumn : Användare, IObserver
    {
        public string Ort { get; set; }
        public string Anställning { get; set; }
        public Utbildning program { get; set; }
        public ICollection<UtskicksLista> Listor { get; set; }
        public ICollection<Aktivitet> Aktiviteter { get; set; }
        public int ExamensÅr { get; set; }

        //observer pattern grejer
        private int ObserverID { get; set; }
        public ISubject listGrabber { get; set; }

        public Alumn()
        {
            Listor = new List<UtskicksLista>();
            Aktiviteter = new List<Aktivitet>();

            //observer pattern grejer
            this.listGrabber = new ListGrabber();
            this.ObserverID = Id;

            listGrabber.register(this);
        }

        

        public override string ToString()
        {
            return AnvändarId + " " + FNamn + " " + ENamn;
        }


        //observer pattern grejer
        public void uppdate()
        {
            throw new NotImplementedException();
        }
    }
}
