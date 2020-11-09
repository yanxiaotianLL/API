using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class zp_companyMap : EntityTypeConfiguration<zp_company>
    {
        public zp_companyMap()
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

            this.Property(t => t.Gtadd)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("zp_company");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Logoimg).HasColumnName("Logoimg");
            this.Property(t => t.Adminid).HasColumnName("Adminid");
            this.Property(t => t.Aid).HasColumnName("Aid");
            this.Property(t => t.Gtadd).HasColumnName("Gtadd");
            this.Property(t => t.Stu).HasColumnName("Stu");
        }
    }
}
