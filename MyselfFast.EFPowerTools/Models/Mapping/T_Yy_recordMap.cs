using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Yy_recordMap : EntityTypeConfiguration<T_Yy_record>
    {
        public T_Yy_recordMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Ulogoname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Uname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ltd)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Yy_record");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Rid).HasColumnName("Rid");
            this.Property(t => t.Ulogoname).HasColumnName("Ulogoname");
            this.Property(t => t.Uname).HasColumnName("Uname");
            this.Property(t => t.Recordtime).HasColumnName("Recordtime");
            this.Property(t => t.fid).HasColumnName("fid");
            this.Property(t => t.ltd).HasColumnName("ltd");
        }
    }
}
