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
        public PersonalRepository(AppDbContext context) : base(context)
        {
            Context = context;
        }

        public void RedigeraPersonal(string ID, string Fnamn, string Enamn, string Email, string TeleNr, string possition)
        {

            int tele = int.Parse(TeleNr);

            var query =
                from personal in Context.Användares
                where personal.AnvändarId == ID
                select personal;

            foreach (Personal personal in query)
            {
                personal.FNamn = Fnamn;
                personal.ENamn = Enamn;
                personal.EMail = Email;
                personal.TeleNr = tele;
                personal.Possition = possition;

            }

            Context.SaveChanges();

        }

        private AppDbContext Context { get; }


    }
}
