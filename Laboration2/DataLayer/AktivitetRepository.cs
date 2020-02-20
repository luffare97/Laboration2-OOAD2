using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntites;

namespace DataLayer
{
    public class AktivitetRepository : GenericRepository<Aktivitet>, IAktivitetRepository
    {
        public AktivitetRepository(AppDbContext context) : base(context)
        {
            Context = context;
        }

        private AppDbContext Context { get; }

        public IEnumerable<Aktivitet> GetAllAktiviteter()
        {
            return Context.Aktiviteter.Where(x => x.AktivitetId == 1);
        }
    }
}
