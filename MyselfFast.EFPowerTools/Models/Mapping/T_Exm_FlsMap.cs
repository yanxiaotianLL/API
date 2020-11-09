using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_FlsMap : EntityTypeConfiguration<T_Exm_Fls>
    {
        public T_Exm_FlsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Ename)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BizLinkMan)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BizLinkPhone)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IsStdCard)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.PageStyle)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FlsCode)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.BizDeptInfo)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_Exm_Fls");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Ename).HasColumnName("Ename");
            this.Property(t => t.BizLinkMan).HasColumnName("BizLinkMan");
            this.Property(t => t.BizLinkPhone).HasColumnName("BizLinkPhone");
            this.Property(t => t.IsStdCard).HasColumnName("IsStdCard");
            this.Property(t => t.IsReturn).HasColumnName("IsReturn");
            this.Property(t => t.PageStyle).HasColumnName("PageStyle");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.FlsCode).HasColumnName("FlsCode");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.BizDeptInfo).HasColumnName("BizDeptInfo");
        }
    }
}
