using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BusinessEntites
{
    public interface IAktivitet
    {
        string AktivitetNamn { get; set; }
        string AntalPlatser { get; set; }
        string Beskrivning { get; set; }
        DateTime Datum { get; set; }
        ObservableCollection<Alumn> Deltagare { get; set; }
        string Plats { get; set; }
        string Tid { get; set; }

        event PropertyChangedEventHandler PropertyChanged;

        void Changed([CallerMemberName] string propertyName = "");
    }
}