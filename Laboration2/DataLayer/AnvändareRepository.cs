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

        private AppDbContext Context { get; }

        public Användare Get(string ID)
        {

            var A = from Användare in AppDbContext.Användares
                    where Användare.AnvändarId == ID;

            
        }

        //public IEnumerable<Användare> GetAnvändare(string användarID)
        //{

        //    return Context.Användares.Where(x => x.AnvändarId == användarID);

        //}
    }
}
