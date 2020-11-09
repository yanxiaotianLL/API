using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_ZP_DisareaMap : EntityTypeConfiguration<T_ZP_Disarea>
    {
        public T_ZP_DisareaMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Dname)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_ZP_Disarea");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Dname).HasColumnName("Dname");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
        }
    }
}
