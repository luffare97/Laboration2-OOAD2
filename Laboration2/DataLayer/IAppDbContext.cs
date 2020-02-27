using BusinessEntites;
using System.Data.Entity;

namespace DataLayer
{
    public interface IAppDbContext
    {
        DbSet<Aktivitet> Aktiviteter { get; set; }
        DbSet<Alumn> Alumner { get; set; }
        DbSet<Användare> Användares { get; set; }
        DbSet<Personal> Personals { get; set; }
        DbSet<UtskicksLista> UtskicksListor { get; set; }

        void Reset();
        void Seed();
    }
}