using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_Report_ItemMap : EntityTypeConfiguration<T_Exm_Report_Item>
    {
        public T_Exm_Report_ItemMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ParentName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.busiCustName)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Exm_Report_Item");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ParentName).HasColumnName("ParentName");
            this.Property(t => t.ConfirmTime).HasColumnName("ConfirmTime");
            this.Property(t => t.ExmType).HasColumnName("ExmType");
            this.Property(t => t.ReportId).HasColumnName("ReportId");
            this.Property(t => t.busiCustId).HasColumnName("busiCustId");
            this.Property(t => t.busiCustName).HasColumnName("busiCustName");
        }
    }
}
