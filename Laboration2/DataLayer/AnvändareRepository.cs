using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntites;

namespace DataLayer
{
    public class AnvändareRepository : GenericRepository<Användare>
    {
        public AnvändareRepository(AppDbContext context) : base(context)
        {
            Context = context;
        }

        public AppDbContext AppDbContext
        {
            get { return Context as AppDbContext;  }
        }

        private AppDbContext Context { get; }
        public List<Användare> användares { get; set; }



        public IEnumerable<Användare> GetAnvändare(string användarID)
        {

            return Context.Användares.Where(x => x.AnvändarId == användarID);
            

        }
    }
}
