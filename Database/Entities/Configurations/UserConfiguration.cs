
namespace Database.Entities.Configurations
{
    using System.Data.Entity.ModelConfiguration;

    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            this.HasKey(m => m.Id);
            this.Property(m => m.Name).IsRequired().HasMaxLength(100);

            this.HasOptional(m => m.Family).WithMany().HasForeignKey(n => n.FamilyId);
        }
    }
}
