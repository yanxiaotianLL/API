using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_YunfeiMap : EntityTypeConfiguration<T_Gds_Yunfei>
    {
        public T_Gds_YunfeiMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Aid, t.Gid, t.Wstart });

            // Properties
            this.Property(t => t.Aid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Aname)
                .IsRequired()
                .HasMaxLength(640);

            this.Property(t => t.Gid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Wstart)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_Gds_Yunfei");
            this.Property(t => t.Aid).HasColumnName("Aid");
            this.Property(t => t.Aname).HasColumnName("Aname");
            this.Property(t => t.Gid).HasColumnName("Gid");
            this.Property(t => t.Wstart).HasColumnName("Wstart");
            this.Property(t => t.Wend).HasColumnName("Wend");
            this.Property(t => t.Base).HasColumnName("Base");
            this.Property(t => t.Ext).HasColumnName("Ext");
            this.Property(t => t.Per).HasColumnName("Per");
            this.Property(t => t.Idx).HasColumnName("Idx");
        }
    }
}
