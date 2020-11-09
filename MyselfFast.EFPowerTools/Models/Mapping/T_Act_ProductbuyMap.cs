using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Act_ProductbuyMap : EntityTypeConfiguration<T_Act_Productbuy>
    {
        public T_Act_ProductbuyMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Productname)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Act_Productbuy");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Parentguid).HasColumnName("Parentguid");
            this.Property(t => t.Userid).HasColumnName("Userid");
            this.Property(t => t.Productname).HasColumnName("Productname");
            this.Property(t => t.Productid).HasColumnName("Productid");
            this.Property(t => t.Buynum).HasColumnName("Buynum");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Totalprice).HasColumnName("Totalprice");
            this.Property(t => t.Subtime).HasColumnName("Subtime");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
        }
    }
}
