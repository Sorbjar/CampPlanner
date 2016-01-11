using Microsoft.Data.Entity;
using System;
using System.Linq;


namespace CampPlanner.Models.Database.Generic
{
    public abstract class GenericDBContext : DbContext, IGenericDBContext
    {

        public GenericDBContext()
        {
        }

        new public int SaveChanges()
        {
            foreach (var entity in this.ChangeTracker.Entries()
                     .Where(e => e.Entity is Statefull)
                     .Select(e => e.Entity as Statefull))
            {
                var entry = Entry(entity);
                entry.State = StateHelpers.ConvertState(entity.State);
                if (entry.State == EntityState.Added ||
                               entry.State == EntityState.Modified)
                {
                    entity.ModifiedDateTime = DateTime.Now;
                }
                if (entry.State == EntityState.Added)
                {
                    entity.CreatedDateTime = DateTime.Now;
                }
            }
            int result = base.SaveChanges();

            return result;
        }

        public void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
    }
}
