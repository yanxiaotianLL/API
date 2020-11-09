using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_S_LogMap : EntityTypeConfiguration<Hth_S_Log>
    {
        public Hth_S_LogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.DataSort)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Result)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Hth_S_Log");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SysUser).HasColumnName("SysUser");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.DoType).HasColumnName("DoType");
            this.Property(t => t.DataSort).HasColumnName("DataSort");
            this.Property(t => t.DataId).HasColumnName("DataId");
            this.Property(t => t.Result).HasColumnName("Result");
        }
    }
}
