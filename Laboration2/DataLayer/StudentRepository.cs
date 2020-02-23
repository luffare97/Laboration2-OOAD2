using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntites;

namespace DataLayer
{
    public class StudentRepository : GenericRepository<Student>
    {
        public StudentRepository(AppDbContext context) : base(context)
        {
            Context = context;
        }

        private AppDbContext Context { get; set; }
        /*
        public static void Läggtillstudent(AppDbContext databas)
        {
            databas.Studenter.Add(new Student()
            {
                Id = 1,
                //AnvändarId = "S20100",
                FNamn = "Per",
                ENamn = "Persson",
                EMail = "PerPersson@student.hb.se",
                TeleNr = 101010022,
            });
            databas.SaveChanges();
        }
        */
    }
}
