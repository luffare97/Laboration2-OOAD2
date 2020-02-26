using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessEntites
{
    public class Alumn : Användare
    {
        public string Ort { get; set; }
        public string Anställning { get; set; }
        public Utbildning program { get; set; }
        public ICollection<UtskicksLista> Listor { get; set; }
        public ICollection<Aktivitet> Aktiviteter { get; set; }

        //Kanske DateTime istället?
        public int ExamensÅr { get; set; }

        public Alumn()
        {
            Listor = new List<UtskicksLista>();
            Aktiviteter = new List<Aktivitet>();
        }

    }
}
