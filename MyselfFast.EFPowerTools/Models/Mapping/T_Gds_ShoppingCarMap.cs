using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_ShoppingCarMap : EntityTypeConfiguration<T_Gds_ShoppingCar>
    {
        public T_Gds_ShoppingCarMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FenTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FenStans)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Hname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Ys1Name)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Ys2Name)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Thumbnail)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Youhuicode)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.ErrorMsg)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Ys1TypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ys2TypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Dealrule)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Gds_ShoppingCar");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.PlanId).HasColumnName("PlanId");
            this.Property(t => t.FenType).HasColumnName("FenType");
            this.Property(t => t.FenTypeName).HasColumnName("FenTypeName");
            this.Property(t => t.FenStans).HasColumnName("FenStans");
            this.Property(t => t.Fenable).HasColumnName("Fenable");
            this.Property(t => t.Spread).HasColumnName("Spread");
            this.Property(t => t.Hid).HasColumnName("Hid");
            this.Property(t => t.Tid).HasColumnName("Tid");
            this.Property(t => t.Hname).HasColumnName("Hname");
            this.Property(t => t.IsMonyOnly).HasColumnName("IsMonyOnly");
            this.Property(t => t.Ys1).HasColumnName("Ys1");
            this.Property(t => t.Ys1Name).HasColumnName("Ys1Name");
            this.Property(t => t.Ys2).HasColumnName("Ys2");
            this.Property(t => t.Ys2Name).HasColumnName("Ys2Name");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.RealWeight).HasColumnName("RealWeight");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.ExtPrice).HasColumnName("ExtPrice");
            this.Property(t => t.Nums).HasColumnName("Nums");
            this.Property(t => t.Costprice).HasColumnName("Costprice");
            this.Property(t => t.Gysid).HasColumnName("Gysid");
            this.Property(t => t.Mprice).HasColumnName("Mprice");
            this.Property(t => t.Yprice).HasColumnName("Yprice");
            this.Property(t => t.GenDate).HasColumnName("GenDate");
            this.Property(t => t.Thumbnail).HasColumnName("Thumbnail");
            this.Property(t => t.IsYouhui).HasColumnName("IsYouhui");
            this.Property(t => t.Youhuicode).HasColumnName("Youhuicode");
            this.Property(t => t.Locked).HasColumnName("Locked");
            this.Property(t => t.IsError).HasColumnName("IsError");
            this.Property(t => t.ErrorMsg).HasColumnName("ErrorMsg");
            this.Property(t => t.Ys1TypeName).HasColumnName("Ys1TypeName");
            this.Property(t => t.Ys2TypeName).HasColumnName("Ys2TypeName");
            this.Property(t => t.DUIPRICE).HasColumnName("DUIPRICE");
            this.Property(t => t.Mtype).HasColumnName("Mtype");
            this.Property(t => t.Dealrule).HasColumnName("Dealrule");
        }
    }
}
