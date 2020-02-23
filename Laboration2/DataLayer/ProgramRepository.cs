using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntites;

namespace DataLayer
{
    public class ProgramRepository : GenericRepository<Program>
    {
        public ProgramRepository(AppDbContext context) : base(context)
        {
            Context = context;
        }

        private AppDbContext Context { get; }
        /*
        public IEnumerable<Program> GetPrograms()
        {
            return Context.Programs.Where(x => x.Id > 0);

        }
        */
    }
}
