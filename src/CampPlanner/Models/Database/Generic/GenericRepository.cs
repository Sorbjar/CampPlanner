using Microsoft.Data.Entity;
using System;
using System.Linq;

namespace CampPlanner.Models.Database.Generic
{
    public abstract class GenericRepository<C, T> :
    IGenericRepository<T> where T : class where C : GenericDBContext, new()
    {

        private C dbContext = new C();
        public C Context
        {
            get { return dbContext; }
            set { dbContext = value; }
        }

        public virtual IQueryable<T> GetAll()
        {
            IQueryable<T> query = dbContext.Set<T>();
            return query;
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = dbContext.Set<T>().Where(predicate);
            return query;
        }

        public virtual T Add(T entity)
        {
            return dbContext.Set<T>().Add(entity).Entity;
        }

        public virtual T Delete(T entity)
        {
            return dbContext.Set<T>().Remove(entity).Entity;
        }

        public virtual T Edit(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public virtual int Save()
        {
            return dbContext.SaveChanges();
        }
    }
}
