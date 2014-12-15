
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace Database.Entities.Configurations
{
    using System.Data.Entity.ModelConfiguration;

    public class FamilyConfiguration : EntityTypeConfiguration<Family>
    {
        public FamilyConfiguration()
        {
            this.HasKey(m => m.Id);
            this.Property(m => m.Surname).IsRequired().HasMaxLength(100);
            this.Property(m => m.Origin).IsRequired().HasMaxLength(100);
            this.Property(m => m.Surname)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute()));
        }
    }
}
