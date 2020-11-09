using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_FOURONE_CODEMap : EntityTypeConfiguration<T_FOURONE_CODE>
    {
        public T_FOURONE_CODEMap()
        {
            // Primary Key
            this.HasKey(t => t.FKEY);

            // Properties
            this.Property(t => t.FKEY)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FTEXT)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.MKEY)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.MTEXT)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.TKEY)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.TTEXT)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PARAM)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_FOURONE_CODE");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FKEY).HasColumnName("FKEY");
            this.Property(t => t.FTEXT).HasColumnName("FTEXT");
            this.Property(t => t.MKEY).HasColumnName("MKEY");
            this.Property(t => t.MTEXT).HasColumnName("MTEXT");
            this.Property(t => t.TKEY).HasColumnName("TKEY");
            this.Property(t => t.TTEXT).HasColumnName("TTEXT");
            this.Property(t => t.PARAM).HasColumnName("PARAM");
            this.Property(t => t.ISCHINA).HasColumnName("ISCHINA");
            this.Property(t => t.ISFOREIGN).HasColumnName("ISFOREIGN");
            this.Property(t => t.ISBJ).HasColumnName("ISBJ");
            this.Property(t => t.ISWHOLE).HasColumnName("ISWHOLE");
            this.Property(t => t.ISSEND).HasColumnName("ISSEND");
            this.Property(t => t.ISDEPOTE).HasColumnName("ISDEPOTE");
            this.Property(t => t.ISAGENCY).HasColumnName("ISAGENCY");
        }
    }
}
