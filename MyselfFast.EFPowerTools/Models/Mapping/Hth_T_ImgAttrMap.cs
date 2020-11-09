using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_ImgAttrMap : EntityTypeConfiguration<Hth_T_ImgAttr>
    {
        public Hth_T_ImgAttrMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.Flag)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.ApiName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Hth_T_ImgAttr");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ImgSort).HasColumnName("ImgSort");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.IType).HasColumnName("IType");
            this.Property(t => t.Calculate).HasColumnName("Calculate");
            this.Property(t => t.AttrSort).HasColumnName("AttrSort");
            this.Property(t => t.OderType).HasColumnName("OderType");
            this.Property(t => t.Flag).HasColumnName("Flag");
            this.Property(t => t.ApiName).HasColumnName("ApiName");
        }
    }
}
