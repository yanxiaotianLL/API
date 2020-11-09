using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_Report_DicMap : EntityTypeConfiguration<T_Exm_Report_Dic>
    {
        public T_Exm_Report_DicMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UnitName)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ParentName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Exm_Report_Dic");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.UnitName).HasColumnName("UnitName");
            this.Property(t => t.ParentName).HasColumnName("ParentName");
        }
    }
}
