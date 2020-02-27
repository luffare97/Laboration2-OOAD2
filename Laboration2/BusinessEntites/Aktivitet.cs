using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites
{
    public class Aktivitet : Entity, IAktivitet
    {
        public string AktivitetNamn { get; set; }
        //public int AktivitetId { get; set; }
        public DateTime Datum { get; set; }
        public string Tid { get; set; }
        public int AntalPlatser { get; set; }
        public string Plats { get; set; }
        public string Beskrivning { get; set; }
        public ICollection<Användare> deltagare { get; set; }

        public Aktivitet()
        {
            deltagare = new List<Användare>();
        }
    }
}
