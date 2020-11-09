using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_Whole_PayMap : EntityTypeConfiguration<T_Gds_Whole_Pay>
    {
        public T_Gds_Whole_PayMap()
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

            // Table & Column Mappings
            this.ToTable("T_Gds_Whole_Pay");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Orderid).HasColumnName("Orderid");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fentype).HasColumnName("Fentype");
            this.Property(t => t.FenTypeName).HasColumnName("FenTypeName");
            this.Property(t => t.FenStans).HasColumnName("FenStans");
            this.Property(t => t.Fenpay).HasColumnName("Fenpay");
            this.Property(t => t.Mnypay).HasColumnName("Mnypay");
            this.Property(t => t.NoMnyPart).HasColumnName("NoMnyPart");
            this.Property(t => t.RealFenpay).HasColumnName("RealFenpay");
            this.Property(t => t.RealMnypay).HasColumnName("RealMnypay");
            this.Property(t => t.BackFen).HasColumnName("BackFen");
            this.Property(t => t.BackMny).HasColumnName("BackMny");
            this.Property(t => t.Yunfei).HasColumnName("Yunfei");
        }
    }
}
