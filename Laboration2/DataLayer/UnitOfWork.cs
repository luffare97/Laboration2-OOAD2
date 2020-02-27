using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntites;

namespace DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;

            //ProgramRepository = new ProgramRepository(Databas);
            AnvändareRepository = new AnvändareRepository(_context);
            AlumnRepository = new AlumnRepository(_context);
            AktivitetRepository = new AktivitetRepository(_context);

            PersonalRepository = new PersonalRepository(_context);
            UtskicksListaRepository = new UtskicksListaRepository(_context);

        }
        public AnvändareRepository AnvändareRepository { get; set; }
        public AlumnRepository AlumnRepository { get; set; }
        public AktivitetRepository AktivitetRepository { get; set; }

        public PersonalRepository PersonalRepository { get; set; }
        public UtskicksListaRepository UtskicksListaRepository { get; set; }

        //public ProgramRepository ProgramRepository { get; set; }

        //public AppDbContext Databas { get; }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
