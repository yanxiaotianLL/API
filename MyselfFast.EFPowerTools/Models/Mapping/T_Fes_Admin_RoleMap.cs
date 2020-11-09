using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_Admin_RoleMap : EntityTypeConfiguration<T_Fes_Admin_Role>
    {
        public T_Fes_Admin_RoleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Rolename)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Rolescript)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CreaterName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EditerName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Fes_Admin_Role");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Rolename).HasColumnName("Rolename");
            this.Property(t => t.Rolescript).HasColumnName("Rolescript");
            this.Property(t => t.ClubAble).HasColumnName("ClubAble");
            this.Property(t => t.FlsAble).HasColumnName("FlsAble");
            this.Property(t => t.SupAble).HasColumnName("SupAble");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreaterId).HasColumnName("CreaterId");
            this.Property(t => t.CreaterName).HasColumnName("CreaterName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.EditerId).HasColumnName("EditerId");
            this.Property(t => t.EditerName).HasColumnName("EditerName");
            this.Property(t => t.EditTime).HasColumnName("EditTime");
            this.Property(t => t.IsGys).HasColumnName("IsGys");
            this.Property(t => t.IsFls).HasColumnName("IsFls");
            this.Property(t => t.IsExm).HasColumnName("IsExm");
        }
    }
}
