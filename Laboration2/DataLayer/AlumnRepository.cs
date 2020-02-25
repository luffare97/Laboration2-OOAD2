using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntites;

namespace DataLayer
{
    public class AlumnRepository : GenericRepository<Alumn> //IAlumnRepository
    {
        public AlumnRepository(AppDbContext context) : base(context)
        {
            Context = context;
        }

        private AppDbContext Context { get; }


        //Metod för att redigera en alumn
        public void RedigeraAlumn(string ID, string Fnamn, string Enamn, string EMail, string TeleNr, string Ort, string Job)
        {

            int tele = int.Parse(TeleNr);

            var query =
                from alumn in Context.Användares
                where alumn.AnvändarId == ID
                select alumn;

            foreach (Alumn alumn in query)
            {
                alumn.FNamn = Fnamn;
                alumn.ENamn = Enamn;
                alumn.EMail = EMail;
                alumn.TeleNr = tele;
                alumn.Ort = Ort;
                alumn.Anställning = Job;

            }

            Context.SaveChanges();

        }

        public void CreateAlumn(string Fnamn, string Enamn, string EMail, int tele, string Ort, string Job, string Lösenord, Utbildning utb, int år)
        {


            Alumn A = new Alumn()
            {
                AnvändarId = $"S{Context.Användares.Count()+1}",
                FNamn = Fnamn,
                ENamn = Enamn,
                EMail = EMail,
                TeleNr = tele,
                Ort = Ort,
                Anställning = Job,
                Lösenord = Lösenord,
                program = utb,
                ExamensÅr = år
                
            };
            
            Context.Alumner.Add(A);

            Context.SaveChanges();
        }


        //Metod för att hämta en Alumn (behövs kanske inte)
        public Alumn GetAlumn(string ID)
        {
            return (Alumn)Context.Användares.Where(x => x.AnvändarId == ID).FirstOrDefault();
        }

        /*
        public IEnumerable<Alumn> GetAllSystemvetare()
        {
            return Context.Alumner.Where(x => x.Program.Id == 1);

        }
       */
    }
}
