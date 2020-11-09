using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_ShouaddrMap : EntityTypeConfiguration<T_Fes_Shouaddr>
    {
        public T_Fes_ShouaddrMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Shouman)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Fname)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Prov)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Xian)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Addr)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Tel)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Postcode)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Bak)
                .IsRequired()
                .HasMaxLength(240);

            this.Property(t => t.AddrTag)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.AddrText)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_Fes_Shouaddr");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Shouman).HasColumnName("Shouman");
            this.Property(t => t.Fname).HasColumnName("Fname");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.ProvId).HasColumnName("ProvId");
            this.Property(t => t.Prov).HasColumnName("Prov");
            this.Property(t => t.XianId).HasColumnName("XianId");
            this.Property(t => t.Xian).HasColumnName("Xian");
            this.Property(t => t.Addr).HasColumnName("Addr");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Postcode).HasColumnName("Postcode");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Bak).HasColumnName("Bak");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");
            this.Property(t => t.AddrTag).HasColumnName("AddrTag");
            this.Property(t => t.AddrText).HasColumnName("AddrText");
        }
    }
}
