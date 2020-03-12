using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntites;

namespace DataLayer
{
    public class PersonalRepository : GenericRepository<Personal>, IPersonalRepository
    {

        private AppDbContext Context { get; }


        public PersonalRepository(AppDbContext context) : base(context)
        {
            Context = context;
        }

        public void RedigeraPersonal(Personal P)
        {

            var query =
                from personal in Context.Användares
                where personal.AnvändarId == P.AnvändarId
                select personal;

            foreach (Personal personal in query)
            {
                personal.FNamn = P.FNamn;
                personal.ENamn = P.ENamn;
                personal.EMail = P.EMail;
                personal.TeleNr = P.TeleNr;
                personal.Possition = P.Possition;

            }

            Context.SaveChanges();

        }

        public Personal GetPersonal(string ID)
        {
            return (Personal)Context.Användares.Where(x => x.AnvändarId == ID).FirstOrDefault();
        }




    }
}
