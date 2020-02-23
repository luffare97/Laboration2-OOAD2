using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites
{
    public class Aktivitet : Entity
    {
        public string AktivitetNamn { get; set; }
        //public int AktivitetId { get; set; }
        public DateTime Start { get; set; }
        public DateTime Slut { get; set; }
        public int AntalPlatser { get; set; }
        public string Plats { get; set; }
        public string Beskrivning { get; set; }

        public Aktivitet()
        {

        }
    }
}
