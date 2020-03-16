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


        //Metod för att redigera en alumn
        public void RedigeraAlumn(Alumn A)
        {

            var query =
                from alumn in Context.Användares
                where alumn.AnvändarId == A.AnvändarId
                select alumn;

            foreach (Alumn alumn in query)
            {
                alumn.FNamn = A.FNamn;
                alumn.ENamn = A.ENamn;
                alumn.EMail = A.EMail;
                alumn.TeleNr = A.TeleNr;
                alumn.Ort = A.Ort;
                alumn.Anställning = A.Anställning;
                alumn.ExamensÅr = A.ExamensÅr;
                alumn.program = A.program;

            }

            Context.SaveChanges();

        }

        public void CreateAlumn(Alumn A)
        {
            //A.AnvändarId = $"s{Context.Användares.Count() + 1}";



            //Alumn A = new Alumn()
            //{
            //    AnvändarId = $"S{Context.Användares.Count() + 1}",
            //    FNamn = Fnamn,
            //    ENamn = Enamn,
            //    EMail = EMail,
            //    TeleNr = tele,
            //    Ort = Ort,
            //    Anställning = Job,
            //    Lösenord = Lösenord,
            //    program = utb,
            //    ExamensÅr = år

            //};

            Context.Alumner.Add(A);


            Context.SaveChanges();
        }


        //Metod för att hämta en Alumn (behövs kanske inte)
        public Alumn GetAlumn(string ID)
        {
            return (Alumn)Context.Användares.Where(x => x.AnvändarId == ID).FirstOrDefault();
        }

        public List<Alumn> GetAllAlumn()
        {
            using (var db = new AppDbContext())
            {
                return db.Alumner.ToList();
            }
        }

    }
}
