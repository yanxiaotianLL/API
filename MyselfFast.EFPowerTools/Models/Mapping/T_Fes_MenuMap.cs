using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_MenuMap : EntityTypeConfiguration<T_Fes_Menu>
    {
        public T_Fes_MenuMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MenuText)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Url)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Context)
                .IsRequired();

            this.Property(t => t.Target)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Fes_Menu");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.Idx).HasColumnName("Idx");
            this.Property(t => t.MenuText).HasColumnName("MenuText");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.Context).HasColumnName("Context");
            this.Property(t => t.Target).HasColumnName("Target");
        }
    }
}
