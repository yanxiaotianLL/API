using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sys_CalendarMap : EntityTypeConfiguration<T_Sys_Calendar>
    {
        public T_Sys_CalendarMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Sys_Calendar");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CYear).HasColumnName("CYear");
            this.Property(t => t.CMonth).HasColumnName("CMonth");
            this.Property(t => t.CDay).HasColumnName("CDay");
            this.Property(t => t.IsWorkDay).HasColumnName("IsWorkDay");
        }
    }
}
