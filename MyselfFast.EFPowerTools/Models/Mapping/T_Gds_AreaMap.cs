using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_AreaMap : EntityTypeConfiguration<T_Gds_Area>
    {
        public T_Gds_AreaMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Hid, t.Cname, t.Areastr, t.Provstr });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Hid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.Areastr)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.Provstr)
                .IsRequired()
                .HasMaxLength(4000);

            // Table & Column Mappings
            this.ToTable("T_Gds_Area");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Hid).HasColumnName("Hid");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Areastr).HasColumnName("Areastr");
            this.Property(t => t.Provstr).HasColumnName("Provstr");
        }
    }
}
