using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_FOURONE_SETMap : EntityTypeConfiguration<T_FOURONE_SET>
    {
        public T_FOURONE_SETMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CNAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LTD)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.ZHIWEI)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.HANGYE)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.EMAIL)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.MOBILE)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_FOURONE_SET");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ISCHINA).HasColumnName("ISCHINA");
            this.Property(t => t.ISFOREIGN).HasColumnName("ISFOREIGN");
            this.Property(t => t.ISBJ).HasColumnName("ISBJ");
            this.Property(t => t.ISWHOLE).HasColumnName("ISWHOLE");
            this.Property(t => t.ISSEND).HasColumnName("ISSEND");
            this.Property(t => t.ISDEPOTE).HasColumnName("ISDEPOTE");
            this.Property(t => t.ISAGENCY).HasColumnName("ISAGENCY");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.CNAME).HasColumnName("CNAME");
            this.Property(t => t.LTD).HasColumnName("LTD");
            this.Property(t => t.ZHIWEI).HasColumnName("ZHIWEI");
            this.Property(t => t.HANGYE).HasColumnName("HANGYE");
            this.Property(t => t.EMAIL).HasColumnName("EMAIL");
            this.Property(t => t.MOBILE).HasColumnName("MOBILE");
            this.Property(t => t.TIMES).HasColumnName("TIMES");
            this.Property(t => t.CREATETIME).HasColumnName("CREATETIME");
        }
    }
}
