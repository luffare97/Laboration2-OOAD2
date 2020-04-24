using BusinessEntites;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DataLayer
{
    public interface IAktivitetRepository : IGenericRepository<Aktivitet>
    {
        void CreateAktivitet(Aktivitet A);
        void DeltaAktivitet(int ID, Alumn A);
        Aktivitet GetAktivitet(int ID);
        List<Aktivitet> GetAllAktiviteter();
        List<Alumn> GetAlumnForAktivitet(Aktivitet aktivitet);
        void RedigeraAktivitet(int ID, Aktivitet A);



    }
}