using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_PackageMap : EntityTypeConfiguration<T_Exm_Package>
    {
        public T_Exm_PackageMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CardRule)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.BriefInfo)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.PContext)
                .IsRequired();

            this.Property(t => t.EName)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.ComName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Duringtime)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Jigous)
                .IsRequired()
                .HasMaxLength(5000);

            this.Property(t => t.Uppackages)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CreaterName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EditerName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ProjectName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Pic)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JigouPage)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.mnmale)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.mnfamale)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.mnfamalemerry)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mnkey)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.MnPassword)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_Exm_Package");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CardRule).HasColumnName("CardRule");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.BriefInfo).HasColumnName("BriefInfo");
            this.Property(t => t.PContext).HasColumnName("PContext");
            this.Property(t => t.EName).HasColumnName("EName");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.ComName).HasColumnName("ComName");
            this.Property(t => t.Pay).HasColumnName("Pay");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.Duringtime).HasColumnName("Duringtime");
            this.Property(t => t.Jigous).HasColumnName("Jigous");
            this.Property(t => t.Uppackages).HasColumnName("Uppackages");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.CostPrice).HasColumnName("CostPrice");
            this.Property(t => t.PackageType).HasColumnName("PackageType");
            this.Property(t => t.CheckType).HasColumnName("CheckType");
            this.Property(t => t.IsFamily).HasColumnName("IsFamily");
            this.Property(t => t.IsCustom).HasColumnName("IsCustom");
            this.Property(t => t.CreaterId).HasColumnName("CreaterId");
            this.Property(t => t.CreaterName).HasColumnName("CreaterName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.EditerId).HasColumnName("EditerId");
            this.Property(t => t.EditerName).HasColumnName("EditerName");
            this.Property(t => t.EditTime).HasColumnName("EditTime");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
            this.Property(t => t.ProjectId).HasColumnName("ProjectId");
            this.Property(t => t.ProjectName).HasColumnName("ProjectName");
            this.Property(t => t.Pic).HasColumnName("Pic");
            this.Property(t => t.IsIntervention).HasColumnName("IsIntervention");
            this.Property(t => t.IsOnline).HasColumnName("IsOnline");
            this.Property(t => t.JigouPage).HasColumnName("JigouPage");
            this.Property(t => t.NewSysPID).HasColumnName("NewSysPID");
            this.Property(t => t.IsUse).HasColumnName("IsUse");
            this.Property(t => t.mnmale).HasColumnName("mnmale");
            this.Property(t => t.mnfamale).HasColumnName("mnfamale");
            this.Property(t => t.mnfamalemerry).HasColumnName("mnfamalemerry");
            this.Property(t => t.IsJoint).HasColumnName("IsJoint");
            this.Property(t => t.Mnkey).HasColumnName("Mnkey");
            this.Property(t => t.MnPassword).HasColumnName("MnPassword");
            this.Property(t => t.IsUpnoPay).HasColumnName("IsUpnoPay");
        }
    }
}
