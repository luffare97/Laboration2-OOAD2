using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites
{
    public class UtskicksLista : Entity
    {

        public string Information { get; set; }
        public string Titel { get; set; }
        public ICollection<Alumn> Användares { get; set; }

        public UtskicksLista()
        {
            Användares = new List<Alumn>();
        }

        public UtskicksLista(string Info, string titel, List<Alumn> folk)
        {
            this.Information = Info;
            this.Titel = titel;
            this.Användares = folk;
        }
    }
}
