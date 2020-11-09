using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_Dan_tempMap : EntityTypeConfiguration<T_Gds_Dan_temp>
    {
        public T_Gds_Dan_tempMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.Dandate, t.Usedname, t.GysName, t.SXno, t.Hname, t.Ysname, t.Ysname2, t.price, t.Nums, t.Shouman, t.Mobile, t.ProvID, t.Prov, t.XianID, t.Xian, t.Addr, t.Postcode, t.Email, t.Remark, t.PlanName, t.PC, t.State, t.ErrorMsg, t.ShouTime, t.OpCause, t.Costprice, t.Fname, t.Script, t.Yewubu, t.YewubuUser });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Usedname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.GysName)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.SXno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Hname)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Ysname)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Ysname2)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.price)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nums)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Shouman)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ProvID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Prov)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.XianID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Xian)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Addr)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Postcode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Remark)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.PlanName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.PC)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.State)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ErrorMsg)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ShouTime)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OpCause)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Costprice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Script)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Yewubu)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.YewubuUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Gds_Dan_temp");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Dandate).HasColumnName("Dandate");
            this.Property(t => t.Usedname).HasColumnName("Usedname");
            this.Property(t => t.GysName).HasColumnName("GysName");
            this.Property(t => t.SXno).HasColumnName("SXno");
            this.Property(t => t.Hname).HasColumnName("Hname");
            this.Property(t => t.Ysname).HasColumnName("Ysname");
            this.Property(t => t.Ysname2).HasColumnName("Ysname2");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.Nums).HasColumnName("Nums");
            this.Property(t => t.Shouman).HasColumnName("Shouman");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.ProvID).HasColumnName("ProvID");
            this.Property(t => t.Prov).HasColumnName("Prov");
            this.Property(t => t.XianID).HasColumnName("XianID");
            this.Property(t => t.Xian).HasColumnName("Xian");
            this.Property(t => t.Addr).HasColumnName("Addr");
            this.Property(t => t.Postcode).HasColumnName("Postcode");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.PlanName).HasColumnName("PlanName");
            this.Property(t => t.PC).HasColumnName("PC");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.ErrorMsg).HasColumnName("ErrorMsg");
            this.Property(t => t.ShouTime).HasColumnName("ShouTime");
            this.Property(t => t.OpCause).HasColumnName("OpCause");
            this.Property(t => t.Costprice).HasColumnName("Costprice");
            this.Property(t => t.Fname).HasColumnName("Fname");
            this.Property(t => t.Script).HasColumnName("Script");
            this.Property(t => t.Yewubu).HasColumnName("Yewubu");
            this.Property(t => t.YewubuUser).HasColumnName("YewubuUser");
        }
    }
}
