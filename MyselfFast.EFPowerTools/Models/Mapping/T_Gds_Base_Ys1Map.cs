using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_Base_Ys1Map : EntityTypeConfiguration<T_Gds_Base_Ys1>
    {
        public T_Gds_Base_Ys1Map()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Img)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Imgs)
                .IsRequired()
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("T_Gds_Base_Ys1");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Hid).HasColumnName("Hid");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
            this.Property(t => t.Isused).HasColumnName("Isused");
            this.Property(t => t.Img).HasColumnName("Img");
            this.Property(t => t.Imgs).HasColumnName("Imgs");
        }
    }
}
