using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Ind_FormalityMap : EntityTypeConfiguration<T_Ind_Formality>
    {
        public T_Ind_FormalityMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FesName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FormalityName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FormalityUrl)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FailReason)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FormlityPreviewUrl)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.BusiRepName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FormalityTypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Ind_Formality");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.FesName).HasColumnName("FesName");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.FormalityType).HasColumnName("FormalityType");
            this.Property(t => t.FormalityName).HasColumnName("FormalityName");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.FormalityLevel).HasColumnName("FormalityLevel");
            this.Property(t => t.FormalityOrder).HasColumnName("FormalityOrder");
            this.Property(t => t.FormalityUrl).HasColumnName("FormalityUrl");
            this.Property(t => t.FatherId).HasColumnName("FatherId");
            this.Property(t => t.FormalityStep).HasColumnName("FormalityStep");
            this.Property(t => t.IndDetailId).HasColumnName("IndDetailId");
            this.Property(t => t.FlowID).HasColumnName("FlowID");
            this.Property(t => t.FailReason).HasColumnName("FailReason");
            this.Property(t => t.StepOrder).HasColumnName("StepOrder");
            this.Property(t => t.FormlityPreviewUrl).HasColumnName("FormlityPreviewUrl");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.SourceType).HasColumnName("SourceType");
            this.Property(t => t.BusiRepName).HasColumnName("BusiRepName");
            this.Property(t => t.IndTaskId).HasColumnName("IndTaskId");
            this.Property(t => t.SenCondition).HasColumnName("SenCondition");
            this.Property(t => t.FormalityTypeName).HasColumnName("FormalityTypeName");
            this.Property(t => t.IsSynchro).HasColumnName("IsSynchro");
        }
    }
}
