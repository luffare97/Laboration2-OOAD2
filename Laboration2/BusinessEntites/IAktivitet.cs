using System;
using System.Collections.Generic;

namespace BusinessEntites
{
    public interface IAktivitet
    {
        string AktivitetNamn { get; set; }
        int AntalPlatser { get; set; }
        string Beskrivning { get; set; }
        DateTime Datum { get; set; }
        ICollection<Alumn> deltagare { get; set; }
        string Plats { get; set; }
        string Tid { get; set; }
    }
}