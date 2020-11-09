using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_CD_PROVINCEMap : EntityTypeConfiguration<V_CD_PROVINCE>
    {
        public V_CD_PROVINCEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.CNAME, t.ENAME, t.IDX });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CNAME)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ENAME)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.IDX)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("V_CD_PROVINCE");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.CNAME).HasColumnName("CNAME");
            this.Property(t => t.ENAME).HasColumnName("ENAME");
            this.Property(t => t.IDX).HasColumnName("IDX");
        }
    }
}
