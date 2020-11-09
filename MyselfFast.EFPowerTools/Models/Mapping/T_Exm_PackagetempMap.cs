using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_PackagetempMap : EntityTypeConfiguration<T_Exm_Packagetemp>
    {
        public T_Exm_PackagetempMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.CardRule, t.Name, t.BriefInfo, t.PContext, t.EName, t.Fid, t.ComName, t.Pay, t.Year, t.Duringtime, t.Jigous, t.Uppackages, t.Status, t.CostPrice, t.PackageType, t.CheckType, t.IsFamily, t.IsCustom, t.CreaterId, t.CreaterName, t.CreateTime, t.EditerId, t.EditerName, t.EditTime, t.Isdelete, t.ProjectId, t.ProjectName, t.Pic, t.IsIntervention, t.IsOnline, t.JigouPage });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CardRule)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.BriefInfo)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.PContext)
                .IsRequired();

            this.Property(t => t.EName)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ComName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Pay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Duringtime)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Jigous)
                .IsRequired()
                .HasMaxLength(5000);

            this.Property(t => t.Uppackages)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CostPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PackageType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CheckType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsFamily)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsCustom)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CreaterId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CreaterName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EditerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EditerName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ProjectId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProjectName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Pic)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JigouPage)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_Exm_Packagetemp");
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
        }
    }
}
