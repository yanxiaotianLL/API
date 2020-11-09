using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_Base_Ys2Map : EntityTypeConfiguration<T_Gds_Base_Ys2>
    {
        public T_Gds_Base_Ys2Map()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Basisource)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Extsource)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Gds_Base_Ys2");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Hid).HasColumnName("Hid");
            this.Property(t => t.Pid).HasColumnName("Pid");
            this.Property(t => t.Sid).HasColumnName("Sid");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Costprice).HasColumnName("Costprice");
            this.Property(t => t.Basisprice).HasColumnName("Basisprice");
            this.Property(t => t.Basisource).HasColumnName("Basisource");
            this.Property(t => t.Extprice).HasColumnName("Extprice");
            this.Property(t => t.Extsource).HasColumnName("Extsource");
            this.Property(t => t.Crossweight).HasColumnName("Crossweight");
            this.Property(t => t.Realweight).HasColumnName("Realweight");
            this.Property(t => t.Kucun).HasColumnName("Kucun");
            this.Property(t => t.Assign).HasColumnName("Assign");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
            this.Property(t => t.Isused).HasColumnName("Isused");
        }
    }
}
