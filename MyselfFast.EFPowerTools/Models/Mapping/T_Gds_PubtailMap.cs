using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_PubtailMap : EntityTypeConfiguration<T_Gds_Pubtail>
    {
        public T_Gds_PubtailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Ys1name)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Ys2name)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Basisource)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Gds_Pubtail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PlanId).HasColumnName("PlanId");
            this.Property(t => t.Hid).HasColumnName("Hid");
            this.Property(t => t.Ys1).HasColumnName("Ys1");
            this.Property(t => t.Ys1name).HasColumnName("Ys1name");
            this.Property(t => t.Ys2).HasColumnName("Ys2");
            this.Property(t => t.Ys2name).HasColumnName("Ys2name");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Extprice).HasColumnName("Extprice");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.Kucun).HasColumnName("Kucun");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
            this.Property(t => t.Costprice).HasColumnName("Costprice");
            this.Property(t => t.Hiskucun).HasColumnName("Hiskucun");
            this.Property(t => t.Discountprice).HasColumnName("Discountprice");
            this.Property(t => t.Basisprice).HasColumnName("Basisprice");
            this.Property(t => t.Basisource).HasColumnName("Basisource");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");
            this.Property(t => t.bakhid).HasColumnName("bakhid");
            this.Property(t => t.IsMonyOnly).HasColumnName("IsMonyOnly");
            this.Property(t => t.Idx).HasColumnName("Idx");
            this.Property(t => t.DUIPRICE).HasColumnName("DUIPRICE");
            this.Property(t => t.Sharefromid).HasColumnName("Sharefromid");
            this.Property(t => t.Gendate).HasColumnName("Gendate");
            this.Property(t => t.FirstUpDate).HasColumnName("FirstUpDate");
            this.Property(t => t.LastDownDate).HasColumnName("LastDownDate");
        }
    }
}
