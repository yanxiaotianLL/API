using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_Pkg_ConfigMap : EntityTypeConfiguration<T_Exm_Pkg_Config>
    {
        public T_Exm_Pkg_ConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Config)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_Exm_Pkg_Config");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Config).HasColumnName("Config");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.PackageId).HasColumnName("PackageId");
        }
    }
}
