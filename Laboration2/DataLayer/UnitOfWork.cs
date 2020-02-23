using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntites;

namespace DataLayer
{
    public class UnitOfWork
    {
        public UnitOfWork(AppDbContext databas)
        {
            Databas = databas;

            //ProgramRepository = new ProgramRepository(Databas);
            UtskicksListaRepository = new UtskicksListaRepository(Databas);
            StudentRepository = new StudentRepository(Databas);
            PersonalRepository = new PersonalRepository(Databas);
            AktivitetRepository = new AktivitetRepository(Databas);
            AlumnRepository = new AlumnRepository(Databas);
        }

        public AlumnRepository AlumnRepository { get; set; }
        public AktivitetRepository AktivitetRepository { get; set; }
        public StudentRepository StudentRepository { get; set; }
        public PersonalRepository PersonalRepository { get; set; }
        public UtskicksListaRepository UtskicksListaRepository { get; set; }
        //public ProgramRepository ProgramRepository { get; set; }

        public AppDbContext Databas { get; }
    }
}
