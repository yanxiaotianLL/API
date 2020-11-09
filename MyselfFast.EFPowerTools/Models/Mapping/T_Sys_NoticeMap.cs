using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sys_NoticeMap : EntityTypeConfiguration<T_Sys_Notice>
    {
        public T_Sys_NoticeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Context)
                .IsRequired()
                .HasMaxLength(4000);

            // Table & Column Mappings
            this.ToTable("T_Sys_Notice");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Context).HasColumnName("Context");
            this.Property(t => t.WakeStart).HasColumnName("WakeStart");
            this.Property(t => t.WakeEnd).HasColumnName("WakeEnd");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
