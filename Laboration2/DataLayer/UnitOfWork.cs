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

            AnvändareRepository = new AnvändareRepository(_context);
            AlumnRepository = new AlumnRepository(_context);
            AktivitetRepository = new AktivitetRepository(_context);
            PersonalRepository = new PersonalRepository(_context);
            UtskicksListaRepository = new UtskicksListaRepository(_context);

        }

        public IAnvändareRepository AnvändareRepository { get; set; }
        public IAlumnRepository AlumnRepository { get; set; }
        public IAktivitetRepository AktivitetRepository { get; set; }
        public IPersonalRepository PersonalRepository { get; set; }
        public IUtskicksListaRepository UtskicksListaRepository { get; set; }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
