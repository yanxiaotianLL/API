using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class C_T_HASMap : EntityTypeConfiguration<C_T_HAS>
    {
        public C_T_HASMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Orderid, t.FenType });

            // Properties
            this.Property(t => t.Orderid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FenType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("_T_HAS");
            this.Property(t => t.Orderid).HasColumnName("Orderid");
            this.Property(t => t.FenType).HasColumnName("FenType");
            this.Property(t => t.Mnypay).HasColumnName("Mnypay");
            this.Property(t => t.Fenpay).HasColumnName("Fenpay");
        }
    }
}
