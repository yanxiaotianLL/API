using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class C_T_ALLMap : EntityTypeConfiguration<C_T_ALL>
    {
        public C_T_ALLMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Orderid, t.FenType });

            // Properties
            this.Property(t => t.Orderid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FenType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("_T_ALL");
            this.Property(t => t.Orderid).HasColumnName("Orderid");
            this.Property(t => t.FenType).HasColumnName("FenType");
            this.Property(t => t.Fenall).HasColumnName("Fenall");
        }
    }
}
