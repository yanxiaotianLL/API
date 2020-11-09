using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_ReportMap : EntityTypeConfiguration<T_Exm_Report>
    {
        public T_Exm_ReportMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.DocRemark)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.T_Sys_FileId)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.ExceptResult)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_Exm_Report");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.FormalityID).HasColumnName("FormalityID");
            this.Property(t => t.UID).HasColumnName("UID");
            this.Property(t => t.ReportState).HasColumnName("ReportState");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.ConfirmState).HasColumnName("ConfirmState");
            this.Property(t => t.ConfirmTime).HasColumnName("ConfirmTime");
            this.Property(t => t.DocID).HasColumnName("DocID");
            this.Property(t => t.DocRemark).HasColumnName("DocRemark");
            this.Property(t => t.ExmType).HasColumnName("ExmType");
            this.Property(t => t.T_Sys_FileId).HasColumnName("T_Sys_FileId");
            this.Property(t => t.ExceptResult).HasColumnName("ExceptResult");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
