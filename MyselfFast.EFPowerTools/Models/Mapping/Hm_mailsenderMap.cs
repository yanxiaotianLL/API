using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hm_mailsenderMap : EntityTypeConfiguration<Hm_mailsender>
    {
        public Hm_mailsenderMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.TITEL)
                .HasMaxLength(200);

            this.Property(t => t.EMAIL)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Hm_mailsender");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TITEL).HasColumnName("TITEL");
            this.Property(t => t.CONTENT).HasColumnName("CONTENT");
            this.Property(t => t.EMAIL).HasColumnName("EMAIL");
            this.Property(t => t.SENDTIME).HasColumnName("SENDTIME");
            this.Property(t => t.SENDSTATE).HasColumnName("SENDSTATE");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.PlanTime).HasColumnName("PlanTime");
        }
    }
}
