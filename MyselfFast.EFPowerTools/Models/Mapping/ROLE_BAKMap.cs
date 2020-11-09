using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class ROLE_BAKMap : EntityTypeConfiguration<ROLE_BAK>
    {
        public ROLE_BAKMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Flable, t.Fesable, t.Onsitable, t.Checkable, t.Onsite_Create_On, t.Isdeleted, t.Midicalable });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Onsite_Create_On)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ROLE_BAK");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Flable).HasColumnName("Flable");
            this.Property(t => t.Fesable).HasColumnName("Fesable");
            this.Property(t => t.Onsitable).HasColumnName("Onsitable");
            this.Property(t => t.Checkable).HasColumnName("Checkable");
            this.Property(t => t.Onsite_Create_On).HasColumnName("Onsite_Create_On");
            this.Property(t => t.Isdeleted).HasColumnName("Isdeleted");
            this.Property(t => t.Midicalable).HasColumnName("Midicalable");
        }
    }
}
