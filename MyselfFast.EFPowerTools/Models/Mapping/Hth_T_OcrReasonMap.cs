using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_OcrReasonMap : EntityTypeConfiguration<Hth_T_OcrReason>
    {
        public Hth_T_OcrReasonMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Message)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Hth_T_OcrReason");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.ImgId).HasColumnName("ImgId");
            this.Property(t => t.ImgType).HasColumnName("ImgType");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.Code).HasColumnName("Code");
        }
    }
}
