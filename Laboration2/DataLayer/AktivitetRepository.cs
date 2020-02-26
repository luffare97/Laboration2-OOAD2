using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntites;

namespace DataLayer
{
    public class AktivitetRepository : GenericRepository<Aktivitet>//, IAktivitetRepository
    {
        public AktivitetRepository(AppDbContext context) : base(context)
        {
            Context = context;
        }

        private AppDbContext Context { get; }

        public List<Aktivitet> GetAllAktiviteter()
        {
            using (var db = new AppDbContext())
            {
                return db.Aktiviteter.ToList();
            }
        }

        public void CreateAktivitet(string titel, int platser, DateTime datum, string tid, string plats, string beskrivning)
        {
            Aktivitet A = new Aktivitet()
            {
                AktivitetNamn = titel,
                AntalPlatser = platser,
                Datum = datum,
                Tid = tid,
                Plats = plats,
                Beskrivning = beskrivning
                
            };

            Context.Aktiviteter.Add(A);
            Context.SaveChanges();
        }


        public Aktivitet GetAktivitet(int ID)
        {
            return (Aktivitet)Context.Aktiviteter.Where(x => x.Id == ID).FirstOrDefault();
        }


        //public IEnumerable<Aktivitet> GetAllAktiviteter()
        //{
        //    int f = 0;
        //    return f;//Context.Aktiviteter.Where(x => x.AktivitetId == 1);
        //}
    }
}
