
namespace Database
{
    using System.Data.Entity;
    using Entities;
    using Entities.Configurations;
    using Contracts;

    public class DataContext : DbContext, IDataContext
    {
        public DataContext()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DataContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new FamilyConfiguration());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Family> Families { get; set; }
    }
}
