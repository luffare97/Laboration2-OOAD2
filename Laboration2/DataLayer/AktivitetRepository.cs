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

        //public Aktivitet GetAktivitetIndex(int id)
        //{
        //    return (Aktivitet)Context.Aktiviteter.Where(id == index)
        //}

        public Aktivitet GetAktivitet(int ID)
        {
            return (Aktivitet)Context.Aktiviteter.Where(x => x.Id == ID).FirstOrDefault();
        }

        public void DeltaAktivitet(int ID, Alumn A)
        {
            var query =
                from aktivitet in Context.Aktiviteter
                where aktivitet.Id == ID
                select aktivitet;

            foreach (Aktivitet aktivitet in query)
            {
                aktivitet.deltagare.Add(A);

                var query2 =
                    from alumn in Context.Alumner
                    where alumn.AnvändarId == A.AnvändarId
                    select alumn;

                foreach (Alumn alumn in query2)
                {
                    alumn.Aktiviteter.Add(aktivitet);
                }
                
                
            }

            Context.SaveChanges();

        }

        public void RedigeraAktivitet(int ID, string titel, int platser, DateTime datum, string tid, string plats, string beskrivning)
        {
            var query =
                from aktivitet in Context.Aktiviteter
                where aktivitet.Id == ID
                select aktivitet;

            foreach (Aktivitet aktivitet in query)
            {
                aktivitet.AktivitetNamn = titel;
                aktivitet.AntalPlatser = platser;
                aktivitet.Datum = datum;
                aktivitet.Tid = tid;
                aktivitet.Plats = plats;
                aktivitet.Beskrivning = beskrivning;

            }

            Context.SaveChanges();
        }


        //public IEnumerable<Aktivitet> GetAllAktiviteter()
        //{
        //    int f = 0;
        //    return f;//Context.Aktiviteter.Where(x => x.AktivitetId == 1);
        //}
    }
}
