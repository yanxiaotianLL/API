using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_GJJZQ_MaterialMap : EntityTypeConfiguration<T_GJJZQ_Material>
    {
        public T_GJJZQ_MaterialMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Material, t.Sort });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Material)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Notes)
                .HasMaxLength(200);

            this.Property(t => t.Sort)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_GJJZQ_Material");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Material).HasColumnName("Material");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Sort).HasColumnName("Sort");
        }
    }
}
