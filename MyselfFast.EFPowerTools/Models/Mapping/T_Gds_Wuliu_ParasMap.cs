using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_Wuliu_ParasMap : EntityTypeConfiguration<T_Gds_Wuliu_Paras>
    {
        public T_Gds_Wuliu_ParasMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Cname, t.Areastr, t.Provstr });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.Areastr)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.Provstr)
                .IsRequired()
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("T_Gds_Wuliu_Paras");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Areastr).HasColumnName("Areastr");
            this.Property(t => t.Provstr).HasColumnName("Provstr");
        }
    }
}
