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
        public ICollection<Alumn> Användares { get; set; }

        public UtskicksLista()
        {
            Användares = new List<Alumn>();
        }

        public UtskicksLista(string Info, string titel, List<Alumn> mottagare)
        {
            this.Information = Info;
            this.Titel = titel;
            this.Användares = mottagare;
        }
    }
}
