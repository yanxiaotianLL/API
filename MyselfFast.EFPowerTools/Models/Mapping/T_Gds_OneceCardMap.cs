using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_OneceCardMap : EntityTypeConfiguration<T_Gds_OneceCard>
    {
        public T_Gds_OneceCardMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Cardnum)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cardpass)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Yewubu)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Yewubuuser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Gds_OneceCard");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Planid).HasColumnName("Planid");
            this.Property(t => t.Cardnum).HasColumnName("Cardnum");
            this.Property(t => t.Cardpass).HasColumnName("Cardpass");
            this.Property(t => t.Cardstatus).HasColumnName("Cardstatus");
            this.Property(t => t.Tiqian).HasColumnName("Tiqian");
            this.Property(t => t.Senddate).HasColumnName("Senddate");
            this.Property(t => t.Sendtype).HasColumnName("Sendtype");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Ismailed).HasColumnName("Ismailed");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Yewubu).HasColumnName("Yewubu");
            this.Property(t => t.Yewubuuser).HasColumnName("Yewubuuser");
            this.Property(t => t.Birthday).HasColumnName("Birthday");
            this.Property(t => t.Microsoftid).HasColumnName("Microsoftid");
        }
    }
}
