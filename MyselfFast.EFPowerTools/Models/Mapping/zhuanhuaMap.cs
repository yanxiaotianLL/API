using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class zhuanhuaMap : EntityTypeConfiguration<zhuanhua>
    {
        public zhuanhuaMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.oldfid, t.newfid });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.oldfid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.newfid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("zhuanhua");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.oldfid).HasColumnName("oldfid");
            this.Property(t => t.newfid).HasColumnName("newfid");
        }
    }
}
