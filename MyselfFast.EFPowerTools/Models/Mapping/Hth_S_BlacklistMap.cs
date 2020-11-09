using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_S_BlacklistMap : EntityTypeConfiguration<Hth_S_Blacklist>
    {
        public Hth_S_BlacklistMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Note)
                .IsRequired()
                .HasMaxLength(350);

            // Table & Column Mappings
            this.ToTable("Hth_S_Blacklist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.SysUser).HasColumnName("SysUser");
        }
    }
}
