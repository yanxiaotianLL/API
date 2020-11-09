using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hm_MailsMap : EntityTypeConfiguration<Hm_Mails>
    {
        public Hm_MailsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Context)
                .IsRequired()
                .HasMaxLength(4000);

            // Table & Column Mappings
            this.ToTable("Hm_Mails");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Uid).HasColumnName("Uid");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Context).HasColumnName("Context");
            this.Property(t => t.Gendate).HasColumnName("Gendate");
            this.Property(t => t.Readstate).HasColumnName("Readstate");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
