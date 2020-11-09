using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_ZP_PerappjobMap : EntityTypeConfiguration<T_ZP_Perappjob>
    {
        public T_ZP_PerappjobMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Jobname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Letterinfo)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_ZP_Perappjob");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Jid).HasColumnName("Jid");
            this.Property(t => t.Pdate).HasColumnName("Pdate");
            this.Property(t => t.Uid).HasColumnName("Uid");
            this.Property(t => t.Comid).HasColumnName("Comid");
            this.Property(t => t.Jobname).HasColumnName("Jobname");
            this.Property(t => t.Letterinfo).HasColumnName("Letterinfo");
        }
    }
}
