namespace CampPlanner.Models.Database.Generic
{
    public interface IGenericDBContext
    {
        int SaveChanges();
        void SetModified(object entity);
    }
}
