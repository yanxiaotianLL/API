using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Jt_CardMap : EntityTypeConfiguration<T_Jt_Card>
    {
        public T_Jt_CardMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.cardnum)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.cardpass)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Fesid)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Jt_Card");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.cardnum).HasColumnName("cardnum");
            this.Property(t => t.cardpass).HasColumnName("cardpass");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.isuse).HasColumnName("isuse");
        }
    }
}
