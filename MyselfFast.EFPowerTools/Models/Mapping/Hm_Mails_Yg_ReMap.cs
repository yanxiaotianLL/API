using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hm_Mails_Yg_ReMap : EntityTypeConfiguration<Hm_Mails_Yg_Re>
    {
        public Hm_Mails_Yg_ReMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Uid)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Context)
                .IsRequired()
                .HasMaxLength(3000);

            // Table & Column Mappings
            this.ToTable("Hm_Mails_Yg_Re");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Ymid).HasColumnName("Ymid");
            this.Property(t => t.Uid).HasColumnName("Uid");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Context).HasColumnName("Context");
            this.Property(t => t.Gendate).HasColumnName("Gendate");
            this.Property(t => t.Readstate).HasColumnName("Readstate");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Fid).HasColumnName("Fid");
        }
    }
}
