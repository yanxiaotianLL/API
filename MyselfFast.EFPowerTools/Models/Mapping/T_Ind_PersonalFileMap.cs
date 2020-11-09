using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Ind_PersonalFileMap : EntityTypeConfiguration<T_Ind_PersonalFile>
    {
        public T_Ind_PersonalFileMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CurrentPlace)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_Ind_PersonalFile");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.AccountType).HasColumnName("AccountType");
            this.Property(t => t.FilePlace).HasColumnName("FilePlace");
            this.Property(t => t.IsReplace).HasColumnName("IsReplace");
            this.Property(t => t.CurrentPlace).HasColumnName("CurrentPlace");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.CertifyType).HasColumnName("CertifyType");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.FormalityId).HasColumnName("FormalityId");
        }
    }
}
