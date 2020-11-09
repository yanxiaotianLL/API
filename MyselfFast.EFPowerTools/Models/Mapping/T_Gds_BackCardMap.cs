using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_BackCardMap : EntityTypeConfiguration<T_Gds_BackCard>
    {
        public T_Gds_BackCardMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.SERIALNUM)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.CLAIMCODE)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.LAIYUAN)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("T_Gds_BackCard");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.SERIALNUM).HasColumnName("SERIALNUM");
            this.Property(t => t.CLAIMCODE).HasColumnName("CLAIMCODE");
            this.Property(t => t.HID).HasColumnName("HID");
            this.Property(t => t.Pubid).HasColumnName("Pubid");
            this.Property(t => t.STATE).HasColumnName("STATE");
            this.Property(t => t.EXPIRATIONDATE).HasColumnName("EXPIRATIONDATE");
            this.Property(t => t.LAIYUAN).HasColumnName("LAIYUAN");
            this.Property(t => t.LINKID).HasColumnName("LINKID");
            this.Property(t => t.Tailid).HasColumnName("Tailid");
            this.Property(t => t.Fid).HasColumnName("Fid");
        }
    }
}
