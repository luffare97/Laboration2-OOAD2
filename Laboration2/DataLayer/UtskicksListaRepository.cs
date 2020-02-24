using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntites;

namespace DataLayer
{
    public class UtskicksListaRepository : GenericRepository<UtskicksLista>
    {
        public UtskicksListaRepository(AppDbContext context) : base(context)
        {
            Context = context;
        }

        public List<UtskicksLista> GetAllListor()
        {
            using (var db = new AppDbContext())
            {
                return db.UtskicksListor.ToList();
            }
        }

        private AppDbContext Context { get; }
    }
}
