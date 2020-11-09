using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_InputvalMap : EntityTypeConfiguration<T_Inputval>
    {
        public T_InputvalMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Mstname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Val)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Inputval");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Activeid).HasColumnName("Activeid");
            this.Property(t => t.Mstname).HasColumnName("Mstname");
            this.Property(t => t.Val).HasColumnName("Val");
        }
    }
}
