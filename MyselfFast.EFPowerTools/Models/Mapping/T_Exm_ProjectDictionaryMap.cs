using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_ProjectDictionaryMap : EntityTypeConfiguration<T_Exm_ProjectDictionary>
    {
        public T_Exm_ProjectDictionaryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ProjectName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Exm_ProjectDictionary");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ProjectName).HasColumnName("ProjectName");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.ProjectBeginTime).HasColumnName("ProjectBeginTime");
            this.Property(t => t.PackageEndTime).HasColumnName("PackageEndTime");
            this.Property(t => t.PayEndTime).HasColumnName("PayEndTime");
            this.Property(t => t.ProjectEndTime).HasColumnName("ProjectEndTime");
            this.Property(t => t.EntryTime).HasColumnName("EntryTime");
        }
    }
}
