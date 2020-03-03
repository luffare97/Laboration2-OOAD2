using System.Collections.Generic;

namespace DataLayer
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        void Uppdate(TEntity entity);
        void Remove(TEntity entity);
        void RemoveRange(ICollection<TEntity> entities);
        void Add(TEntity entity);
        void AddRange(ICollection<TEntity> entities);
        TEntity Get(int id);
        ICollection<TEntity> GetAll();
    }
}