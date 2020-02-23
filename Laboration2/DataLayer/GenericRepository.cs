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

        public void AddToRepo()
        {

        }

        //public TEntity Get()
        //{

        //}

        
        //public TEntity Get()
        //{
        //   return Context.Set<TEntity>().Get();
        //}
        

        public List<TEntity> GetAll()
        {

            List<TEntity> Saker = new List<TEntity>();


            return Saker;
        }


    }
}
