using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hm_Sql_LogMap : EntityTypeConfiguration<Hm_Sql_Log>
    {
        public Hm_Sql_LogMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Otype)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Oname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Sqltext)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.Paratext)
                .IsRequired();

            this.Property(t => t.Error)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Hm_Sql_Log");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Otype).HasColumnName("Otype");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.Oname).HasColumnName("Oname");
            this.Property(t => t.Gendate).HasColumnName("Gendate");
            this.Property(t => t.Sqltext).HasColumnName("Sqltext");
            this.Property(t => t.Paratext).HasColumnName("Paratext");
            this.Property(t => t.Error).HasColumnName("Error");
        }
    }
}
