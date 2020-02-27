using System.Collections.Generic;

namespace DataLayer
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void AddToRepo();
        List<TEntity> GetAll();
    }
}