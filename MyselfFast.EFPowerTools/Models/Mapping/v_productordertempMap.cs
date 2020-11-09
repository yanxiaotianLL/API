using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class v_productordertempMap : EntityTypeConfiguration<v_productordertemp>
    {
        public v_productordertempMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Userid, t.Totalpay, t.Subtime, t.Status, t.Tguid, t.Danno, t.Shouman, t.Shoutel, t.Shouaddress, t.Shoupost, t.Sendtype, t.Ispiao, t.Piaotitle, t.Piaouse, t.Paytype, t.Paytime, t.Sex, t.username, t.Uid, t.Buynum });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Userid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Totalpay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.Sendtype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ispiao)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Piaotitle)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Piaouse)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Paytype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.username)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Uid)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Buynum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("v_productordertemp");
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
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.username).HasColumnName("username");
            this.Property(t => t.Uid).HasColumnName("Uid");
            this.Property(t => t.Buynum).HasColumnName("Buynum");
        }
    }
}
