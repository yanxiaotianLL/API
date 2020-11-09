using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_User_ExtMap : EntityTypeConfiguration<T_Exm_User_Ext>
    {
        public T_Exm_User_ExtMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BoeApplicantCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Exm_User_Ext");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.BoeApplicantId).HasColumnName("BoeApplicantId");
            this.Property(t => t.BoeApplicantCode).HasColumnName("BoeApplicantCode");
            this.Property(t => t.BoeJobId).HasColumnName("BoeJobId");
            this.Property(t => t.BoeRecruitCategory).HasColumnName("BoeRecruitCategory");
            this.Property(t => t.BoeStatusId).HasColumnName("BoeStatusId");
            this.Property(t => t.OperateTime).HasColumnName("OperateTime");
            this.Property(t => t.BoeIsSendReport).HasColumnName("BoeIsSendReport");
            this.Property(t => t.BoeSendReportTime).HasColumnName("BoeSendReportTime");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
        }
    }
}
