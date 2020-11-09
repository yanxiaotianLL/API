//
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using myselfFast.Fund.Core.Domain.Hukou;
using myselfFast.Fund.Core.Domain;

namespace myselfFast.Fund.Data.Mapping.Hukou
{
    public class V_CD_XIANMap : myselfFastEntityTypeConfiguration<V_CD_XIAN>
    {
        public V_CD_XIANMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SID, t.PROVINCE, t.id, t.CNAME, t.ENAME, t.IDX, t.IPID, t.SHOW });

            // Properties
            this.Property(t => t.SID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PROVINCE)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CNAME)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ENAME)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.IDX)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IPID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("V_CD_XIAN");
            this.Property(t => t.SID).HasColumnName("SID");
            this.Property(t => t.PROVINCE).HasColumnName("PROVINCE");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.CNAME).HasColumnName("CNAME");
            this.Property(t => t.ENAME).HasColumnName("ENAME");
            this.Property(t => t.IDX).HasColumnName("IDX");
            this.Property(t => t.IPID).HasColumnName("IPID");
            this.Property(t => t.SHOW).HasColumnName("SHOW");
        }
    }
}
