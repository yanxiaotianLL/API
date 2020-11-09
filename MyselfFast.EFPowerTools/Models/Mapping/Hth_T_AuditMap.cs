using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_AuditMap : EntityTypeConfiguration<Hth_T_Audit>
    {
        public Hth_T_AuditMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Content)
                .IsRequired()
                .HasMaxLength(350);

            this.Property(t => t.ContentIds)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Hth_T_Audit");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ImgId).HasColumnName("ImgId");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.AuUser).HasColumnName("AuUser");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.AuUserType).HasColumnName("AuUserType");
            this.Property(t => t.AuState).HasColumnName("AuState");
            this.Property(t => t.AuType).HasColumnName("AuType");
            this.Property(t => t.ContentIds).HasColumnName("ContentIds");
        }
    }
}
