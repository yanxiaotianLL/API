using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_OrderWrapMap : EntityTypeConfiguration<Hth_T_OrderWrap>
    {
        public Hth_T_OrderWrapMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Des)
                .HasMaxLength(50);

            this.Property(t => t.PdfSummary)
                .HasMaxLength(4000);

            this.Property(t => t.PdfDetailed)
                .HasMaxLength(4000);

            // Table & Column Mappings
            this.ToTable("Hth_T_OrderWrap");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.IsDel).HasColumnName("IsDel");
            this.Property(t => t.Des).HasColumnName("Des");
            this.Property(t => t.VisitsStartTime).HasColumnName("VisitsStartTime");
            this.Property(t => t.VisitsEndTime).HasColumnName("VisitsEndTime");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.IsExemptPaperBill).HasColumnName("IsExemptPaperBill");
            this.Property(t => t.PdfSummary).HasColumnName("PdfSummary");
            this.Property(t => t.PdfDetailed).HasColumnName("PdfDetailed");
        }
    }
}
