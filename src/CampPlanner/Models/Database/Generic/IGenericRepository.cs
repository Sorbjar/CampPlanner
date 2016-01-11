using System;
using System.Linq;
using System.Linq.Expressions;

namespace CampPlanner.Models.Database.Generic
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        T Add(T entity);
        T Delete(T entity);
        T Edit(T entity);
        int Save();
    }
}
