using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_PjigouMap : EntityTypeConfiguration<T_Exm_Pjigou>
    {
        public T_Exm_PjigouMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InterFacePath)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PassWord)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Exm_Pjigou");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.InterFacePath).HasColumnName("InterFacePath");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.PassWord).HasColumnName("PassWord");
            this.Property(t => t.IsBackReport).HasColumnName("IsBackReport");
        }
    }
}
