using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_ZP_CompanyMap : EntityTypeConfiguration<T_ZP_Company>
    {
        public T_ZP_CompanyMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Logoimg)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Adminid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ZP_DisareaId)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_ZP_Company");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Logoimg).HasColumnName("Logoimg");
            this.Property(t => t.Adminid).HasColumnName("Adminid");
            this.Property(t => t.Aid).HasColumnName("Aid");
            this.Property(t => t.Gtadd).HasColumnName("Gtadd");
            this.Property(t => t.Stu).HasColumnName("Stu");
            this.Property(t => t.ZP_DisareaId).HasColumnName("ZP_DisareaId");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
        }
    }
}
