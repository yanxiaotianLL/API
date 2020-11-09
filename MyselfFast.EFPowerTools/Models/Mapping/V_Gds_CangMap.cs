using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_Gds_CangMap : EntityTypeConfiguration<V_Gds_Cang>
    {
        public V_Gds_CangMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.PlanId, t.Hid, t.Ys1, t.Ys1name, t.Ys2, t.Ys2name, t.Price, t.Extprice, t.Weight, t.Kucun, t.Isdelete, t.Costprice, t.Hiskucun, t.Discountprice, t.Basisprice, t.Basisource, t.IsDefault, t.bakhid, t.IsMonyOnly, t.Numbers, t.Cname, t.Ename, t.Img });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PlanId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Hid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ys1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ys1name)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Ys2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ys2name)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Price)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Extprice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Weight)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Kucun)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Costprice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Hiskucun)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Discountprice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Basisprice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Basisource)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.bakhid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Numbers)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Ename)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Img)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("V_Gds_Cang");
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
            this.Property(t => t.Numbers).HasColumnName("Numbers");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Ename).HasColumnName("Ename");
            this.Property(t => t.Img).HasColumnName("Img");
        }
    }
}
