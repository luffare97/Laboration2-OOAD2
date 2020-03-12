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
            Context.SaveChanges();
        }

        public void RemoveRange(ICollection<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
            Context.SaveChanges();
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
        }

        public void AddRange(ICollection<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
            Context.SaveChanges();
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
