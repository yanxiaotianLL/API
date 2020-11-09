using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_ZP_UserinfoMap : EntityTypeConfiguration<T_ZP_Userinfo>
    {
        public T_ZP_UserinfoMap()
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
                .HasMaxLength(100);

            this.Property(t => t.Internshipinfo)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.InternshipCompany)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Speciality)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Degree)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_ZP_Userinfo");
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
            this.Property(t => t.InternshipCompany).HasColumnName("InternshipCompany");
            this.Property(t => t.Speciality).HasColumnName("Speciality");
            this.Property(t => t.Degree).HasColumnName("Degree");
            this.Property(t => t.Source).HasColumnName("Source");
        }
    }
}
