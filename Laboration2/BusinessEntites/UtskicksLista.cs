using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites
{
    public class UtskicksLista : Entity, IUtskicksLista
    {

        public string Information { get; set; }
        public string Titel { get; set; }
        public ICollection<Alumn> Mottagare { get; set; }

        public UtskicksLista()
        {
            Mottagare = new List<Alumn>();
        }

        public UtskicksLista(string Info, string titel, List<Alumn> mottagare)
        {
            this.Information = Info;
            this.Titel = titel;
            this.Mottagare = mottagare;
        }
    }
}
