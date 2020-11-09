using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_Admin_PartMap : EntityTypeConfiguration<T_Fes_Admin_Part>
    {
        public T_Fes_Admin_PartMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.PartName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.CreaterName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EditerName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Fes_Admin_Part");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.PartName).HasColumnName("PartName");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.LevelIs).HasColumnName("LevelIs");
            this.Property(t => t.HasChildren).HasColumnName("HasChildren");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreaterId).HasColumnName("CreaterId");
            this.Property(t => t.CreaterName).HasColumnName("CreaterName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.EditerId).HasColumnName("EditerId");
            this.Property(t => t.EditerName).HasColumnName("EditerName");
            this.Property(t => t.EditTime).HasColumnName("EditTime");
        }
    }
}
