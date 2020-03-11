using BusinessEntites;
using System;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IAktivitetRepository
    {
        void CreateAktivitet(Aktivitet A);
        void DeltaAktivitet(int ID, Alumn A);
        Aktivitet GetAktivitet(int ID);
        List<Aktivitet> GetAllAktiviteter();
        void RedigeraAktivitet(int ID, Aktivitet A);
    }
}