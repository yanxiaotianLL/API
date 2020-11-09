using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sohu_Dan_ReTransferMap : EntityTypeConfiguration<T_Sohu_Dan_ReTransfer>
    {
        public T_Sohu_Dan_ReTransferMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.State, t.Gendate });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.SH_EB_ORDER_ID)
                .HasMaxLength(50);

            this.Property(t => t.State)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_Sohu_Dan_ReTransfer");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.SH_EB_ORDER_ID).HasColumnName("SH_EB_ORDER_ID");
            this.Property(t => t.SH_MAIN_SPEC_NAME).HasColumnName("SH_MAIN_SPEC_NAME");
            this.Property(t => t.SH_SUB_SPEC_NAME).HasColumnName("SH_SUB_SPEC_NAME");
            this.Property(t => t.SH_PRODUCT_ID).HasColumnName("SH_PRODUCT_ID");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Gendate).HasColumnName("Gendate");
        }
    }
}
