using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class zp_userinfoMap : EntityTypeConfiguration<zp_userinfo>
    {
        public zp_userinfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Openid)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Uname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.University)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Profession)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Phone)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Cardid)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Internshiptime)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Internshipinfo)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("zp_userinfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Openid).HasColumnName("Openid");
            this.Property(t => t.Uname).HasColumnName("Uname");
            this.Property(t => t.Ubirthday).HasColumnName("Ubirthday");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.University).HasColumnName("University");
            this.Property(t => t.Profession).HasColumnName("Profession");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Cardid).HasColumnName("Cardid");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Internshiptime).HasColumnName("Internshiptime");
            this.Property(t => t.Internshipinfo).HasColumnName("Internshipinfo");
        }
    }
}
