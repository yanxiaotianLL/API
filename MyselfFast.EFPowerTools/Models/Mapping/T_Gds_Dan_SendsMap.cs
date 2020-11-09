using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_Dan_SendsMap : EntityTypeConfiguration<T_Gds_Dan_Sends>
    {
        public T_Gds_Dan_SendsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.OrderNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Shouman)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Shoultd)
                .IsRequired()
                .HasMaxLength(260);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.AddrTag)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.AddrText)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Prov)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Xian)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Addr)
                .IsRequired()
                .HasMaxLength(260);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Tel)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Postcode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Postman)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Postltd)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Postaddr)
                .IsRequired()
                .HasMaxLength(260);

            this.Property(t => t.Postmobile)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Posttel)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Wcname)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.Goodscript)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.Goodsize)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Kdno)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Beizhu)
                .IsRequired()
                .HasMaxLength(1200);

            // Table & Column Mappings
            this.ToTable("T_Gds_Dan_Sends");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Gysid).HasColumnName("Gysid");
            this.Property(t => t.Orderid).HasColumnName("Orderid");
            this.Property(t => t.OrderNo).HasColumnName("OrderNo");
            this.Property(t => t.Kid).HasColumnName("Kid");
            this.Property(t => t.Shouman).HasColumnName("Shouman");
            this.Property(t => t.Shoultd).HasColumnName("Shoultd");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Addrid).HasColumnName("Addrid");
            this.Property(t => t.AddrTag).HasColumnName("AddrTag");
            this.Property(t => t.AddrText).HasColumnName("AddrText");
            this.Property(t => t.Prov).HasColumnName("Prov");
            this.Property(t => t.Xian).HasColumnName("Xian");
            this.Property(t => t.Addr).HasColumnName("Addr");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Postcode).HasColumnName("Postcode");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Postman).HasColumnName("Postman");
            this.Property(t => t.Postltd).HasColumnName("Postltd");
            this.Property(t => t.Postaddr).HasColumnName("Postaddr");
            this.Property(t => t.Postmobile).HasColumnName("Postmobile");
            this.Property(t => t.Posttel).HasColumnName("Posttel");
            this.Property(t => t.Areaid).HasColumnName("Areaid");
            this.Property(t => t.Wcname).HasColumnName("Wcname");
            this.Property(t => t.Goodscript).HasColumnName("Goodscript");
            this.Property(t => t.Goodsnum).HasColumnName("Goodsnum");
            this.Property(t => t.Goodsnums).HasColumnName("Goodsnums");
            this.Property(t => t.Goodsize).HasColumnName("Goodsize");
            this.Property(t => t.Baofei).HasColumnName("Baofei");
            this.Property(t => t.Kdfei).HasColumnName("Kdfei");
            this.Property(t => t.Sendfei).HasColumnName("Sendfei");
            this.Property(t => t.Sdate).HasColumnName("Sdate");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Kdno).HasColumnName("Kdno");
            this.Property(t => t.Beizhu).HasColumnName("Beizhu");
        }
    }
}
