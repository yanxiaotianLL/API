using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Clb_ClubsMap : EntityTypeConfiguration<T_Clb_Clubs>
    {
        public T_Clb_ClubsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Cusername)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Cuserpwd)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ccode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Caddress)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Cpost)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ccontact)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Ctel)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cphone)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cfax)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cemail)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Cqq)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Cmsn)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Logip)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Logimg)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Link)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("T_Clb_Clubs");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Ctype).HasColumnName("Ctype");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Cusername).HasColumnName("Cusername");
            this.Property(t => t.Cuserpwd).HasColumnName("Cuserpwd");
            this.Property(t => t.Ccode).HasColumnName("Ccode");
            this.Property(t => t.Caddress).HasColumnName("Caddress");
            this.Property(t => t.Cpost).HasColumnName("Cpost");
            this.Property(t => t.Ccontact).HasColumnName("Ccontact");
            this.Property(t => t.Ctel).HasColumnName("Ctel");
            this.Property(t => t.Cphone).HasColumnName("Cphone");
            this.Property(t => t.Cfax).HasColumnName("Cfax");
            this.Property(t => t.Cemail).HasColumnName("Cemail");
            this.Property(t => t.Cqq).HasColumnName("Cqq");
            this.Property(t => t.Cmsn).HasColumnName("Cmsn");
            this.Property(t => t.Logtime).HasColumnName("Logtime");
            this.Property(t => t.Logip).HasColumnName("Logip");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
            this.Property(t => t.Logimg).HasColumnName("Logimg");
            this.Property(t => t.Isshow).HasColumnName("Isshow");
            this.Property(t => t.Discuzid).HasColumnName("Discuzid");
            this.Property(t => t.Isdiscuz).HasColumnName("Isdiscuz");
            this.Property(t => t.Islink).HasColumnName("Islink");
            this.Property(t => t.Link).HasColumnName("Link");
            this.Property(t => t.Disid).HasColumnName("Disid");
        }
    }
}
