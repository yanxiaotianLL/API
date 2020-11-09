using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_Admin_ManagerMap : EntityTypeConfiguration<T_Fes_Admin_Manager>
    {
        public T_Fes_Admin_ManagerMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.UserId)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.RealName)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.EName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Script)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Pass)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.PartName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RoleName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Lastip)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.CreaterName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EditerName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Fes_Admin_Manager");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.RealName).HasColumnName("RealName");
            this.Property(t => t.EName).HasColumnName("EName");
            this.Property(t => t.Script).HasColumnName("Script");
            this.Property(t => t.Pass).HasColumnName("Pass");
            this.Property(t => t.PartId).HasColumnName("PartId");
            this.Property(t => t.PartName).HasColumnName("PartName");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.RoleName).HasColumnName("RoleName");
            this.Property(t => t.IsAdmin).HasColumnName("IsAdmin");
            this.Property(t => t.PageSize).HasColumnName("PageSize");
            this.Property(t => t.Lastip).HasColumnName("Lastip");
            this.Property(t => t.Lastlogintime).HasColumnName("Lastlogintime");
            this.Property(t => t.Visittimes).HasColumnName("Visittimes");
            this.Property(t => t.CreaterId).HasColumnName("CreaterId");
            this.Property(t => t.CreaterName).HasColumnName("CreaterName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.EditerId).HasColumnName("EditerId");
            this.Property(t => t.EditerName).HasColumnName("EditerName");
            this.Property(t => t.EditTime).HasColumnName("EditTime");
            this.Property(t => t.StateLogin).HasColumnName("StateLogin");
            this.Property(t => t.FlsArea).HasColumnName("FlsArea");
            this.Property(t => t.BelongId).HasColumnName("BelongId");
        }
    }
}
