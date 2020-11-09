using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_Fls_NoticeTypeMap : EntityTypeConfiguration<T_Fes_Fls_NoticeType>
    {
        public T_Fes_Fls_NoticeTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Cname });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_Fes_Fls_NoticeType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Cname).HasColumnName("Cname");
        }
    }
}
