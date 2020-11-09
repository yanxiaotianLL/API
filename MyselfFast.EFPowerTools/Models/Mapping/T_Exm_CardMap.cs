using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_CardMap : EntityTypeConfiguration<T_Exm_Card>
    {
        public T_Exm_CardMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CheckNo)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.PassWord)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CardRule)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CardRule_Old)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CheckvalNo)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.OldcheckNo)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Business)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PersonId)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PersonName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PersonSex)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.PackageIds)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.BizDept)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BizDeptSalesman)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Exm_Card");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ProjectId).HasColumnName("ProjectId");
            this.Property(t => t.PackageId).HasColumnName("PackageId");
            this.Property(t => t.CheckNo).HasColumnName("CheckNo");
            this.Property(t => t.PassWord).HasColumnName("PassWord");
            this.Property(t => t.CardRule).HasColumnName("CardRule");
            this.Property(t => t.CardRule_Old).HasColumnName("CardRule_Old");
            this.Property(t => t.CheckvalNo).HasColumnName("CheckvalNo");
            this.Property(t => t.CheckvalId).HasColumnName("CheckvalId");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.IsBind).HasColumnName("IsBind");
            this.Property(t => t.IsCustom).HasColumnName("IsCustom");
            this.Property(t => t.OldPackageId).HasColumnName("OldPackageId");
            this.Property(t => t.OldcheckNo).HasColumnName("OldcheckNo");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.BusinessId).HasColumnName("BusinessId");
            this.Property(t => t.Business).HasColumnName("Business");
            this.Property(t => t.PreId).HasColumnName("PreId");
            this.Property(t => t.PersonId).HasColumnName("PersonId");
            this.Property(t => t.PersonName).HasColumnName("PersonName");
            this.Property(t => t.PersonSex).HasColumnName("PersonSex");
            this.Property(t => t.PackageIds).HasColumnName("PackageIds");
            this.Property(t => t.UseState).HasColumnName("UseState");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.LStart).HasColumnName("LStart");
            this.Property(t => t.LEnd).HasColumnName("LEnd");
            this.Property(t => t.LDays).HasColumnName("LDays");
            this.Property(t => t.Old_ProjectId).HasColumnName("Old_ProjectId");
            this.Property(t => t.Divid).HasColumnName("Divid");
            this.Property(t => t.IsIntervention).HasColumnName("IsIntervention");
            this.Property(t => t.BizDept).HasColumnName("BizDept");
            this.Property(t => t.IsOwnUse).HasColumnName("IsOwnUse");
            this.Property(t => t.BizFid).HasColumnName("BizFid");
            this.Property(t => t.IsTestCard).HasColumnName("IsTestCard");
            this.Property(t => t.OrderItemId).HasColumnName("OrderItemId");
            this.Property(t => t.BizDeptSalesman).HasColumnName("BizDeptSalesman");
        }
    }
}
