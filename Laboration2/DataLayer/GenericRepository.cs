using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntites;

namespace DataLayer
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        public GenericRepository(AppDbContext context)
        {
            Context = context;
        }

        private AppDbContext Context { get; }

        //public AddToRepo()
        //{

        //}
        /*
        public TEntity Get()
        {
           return Context.Set<TEntity>().Get();
        }
        */

        //public GetAll()
        //{

        //}


    }
}
