
namespace Database.Contracts
{
    using System.Data.Entity;
    using Entities;

    public interface IDataContext
    {
           DbSet<User> Users { get; }
           DbSet<Family> Families { get; }

           int SaveChanges();
    }
}
