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

        //public IEnumerable<Aktivitet> GetAllAktiviteter()
        //{
        //    int f = 0;
        //    return f;//Context.Aktiviteter.Where(x => x.AktivitetId == 1);
        //}
    }
}
