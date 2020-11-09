using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_AssessmentResultMap : EntityTypeConfiguration<T_Exm_AssessmentResult>
    {
        public T_Exm_AssessmentResultMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Topic)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.TestResult)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Remark)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Suggest)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("T_Exm_AssessmentResult");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.PackageId).HasColumnName("PackageId");
            this.Property(t => t.Topic).HasColumnName("Topic");
            this.Property(t => t.TestResult).HasColumnName("TestResult");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.Suggest).HasColumnName("Suggest");
            this.Property(t => t.DoneTime).HasColumnName("DoneTime");
            this.Property(t => t.SubTime).HasColumnName("SubTime");
        }
    }
}
