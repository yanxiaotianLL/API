using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_FOURONE_SET_TAILMap : EntityTypeConfiguration<T_FOURONE_SET_TAIL>
    {
        public T_FOURONE_SET_TAILMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SETID, t.FKEY });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.SETID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FKEY)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FVALUE)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_FOURONE_SET_TAIL");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SETID).HasColumnName("SETID");
            this.Property(t => t.FKEY).HasColumnName("FKEY");
            this.Property(t => t.FVALUE).HasColumnName("FVALUE");
        }
    }
}
