using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntites;

namespace DataLayer
{
    public class AlumnRepository : GenericRepository<Alumn>, IAlumnRepository
    {
        public AlumnRepository(AppDbContext context) : base(context)
        {
            Context = context;
        }

        private AppDbContext Context { get; }

        public IEnumerable<Alumn> GetAllSystemvetare()
        {
            return Context.Alumns.Where(x => x.Program.ID == 1);

        }
    }
}
