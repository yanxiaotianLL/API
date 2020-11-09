using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Act_ProductordertempMap : EntityTypeConfiguration<T_Act_Productordertemp>
    {
        public T_Act_ProductordertempMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Danno)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Shouman)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Shoutel)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Shouaddress)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Shoupost)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Piaotitle)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Piaouse)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Act_Productordertemp");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Userid).HasColumnName("Userid");
            this.Property(t => t.Totalpay).HasColumnName("Totalpay");
            this.Property(t => t.Subtime).HasColumnName("Subtime");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Tguid).HasColumnName("Tguid");
            this.Property(t => t.Danno).HasColumnName("Danno");
            this.Property(t => t.Shouman).HasColumnName("Shouman");
            this.Property(t => t.Shoutel).HasColumnName("Shoutel");
            this.Property(t => t.Shouaddress).HasColumnName("Shouaddress");
            this.Property(t => t.Shoupost).HasColumnName("Shoupost");
            this.Property(t => t.Sendtype).HasColumnName("Sendtype");
            this.Property(t => t.Ispiao).HasColumnName("Ispiao");
            this.Property(t => t.Piaotitle).HasColumnName("Piaotitle");
            this.Property(t => t.Piaouse).HasColumnName("Piaouse");
            this.Property(t => t.Paytype).HasColumnName("Paytype");
            this.Property(t => t.Paytime).HasColumnName("Paytime");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
        }
    }
}
