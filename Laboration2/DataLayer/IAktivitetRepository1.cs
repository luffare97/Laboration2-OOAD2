using BusinessEntites;
using System;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IAktivitetRepository1
    {
        void CreateAktivitet(string titel, int platser, DateTime datum, string tid, string plats, string beskrivning);
        void DeltaAktivitet(int ID, Alumn A);
        Aktivitet GetAktivitet(int ID);
        List<Aktivitet> GetAllAktiviteter();
        void RedigeraAktivitet(int ID, string titel, int platser, DateTime datum, string tid, string plats, string beskrivning);
    }
}