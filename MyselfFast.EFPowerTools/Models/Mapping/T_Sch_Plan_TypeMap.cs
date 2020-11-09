using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sch_Plan_TypeMap : EntityTypeConfiguration<T_Sch_Plan_Type>
    {
        public T_Sch_Plan_TypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Tname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ProcName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Sch_Plan_Type");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Tname).HasColumnName("Tname");
            this.Property(t => t.ProcName).HasColumnName("ProcName");
        }
    }
}
