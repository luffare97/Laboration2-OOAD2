using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessEntites;

namespace DataLayer
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public GenericRepository(AppDbContext context)
        {
            Context = context;
        }

        private AppDbContext Context { get; }


        public void Create(TEntity entity)
        {
            
        }

        public void Uppdate(TEntity entity)
        {

        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(ICollection<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(ICollection<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
            
            
        }

        public ICollection<TEntity> GetAll()
        {

            return Context.Set<TEntity>().ToList();

        }


    }
}
