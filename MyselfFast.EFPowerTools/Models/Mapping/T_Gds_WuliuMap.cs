using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_WuliuMap : EntityTypeConfiguration<T_Gds_Wuliu>
    {
        public T_Gds_WuliuMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Addr)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Postcode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.Tel)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Opuser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.KD100CODE)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.KDBIRDCODE)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Gds_Wuliu");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Addr).HasColumnName("Addr");
            this.Property(t => t.Postcode).HasColumnName("Postcode");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Gendate).HasColumnName("Gendate");
            this.Property(t => t.Opuser).HasColumnName("Opuser");
            this.Property(t => t.KD100CODE).HasColumnName("KD100CODE");
            this.Property(t => t.KDBIRDCODE).HasColumnName("KDBIRDCODE");
        }
    }
}
