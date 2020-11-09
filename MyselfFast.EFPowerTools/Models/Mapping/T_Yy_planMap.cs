using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Yy_planMap : EntityTypeConfiguration<T_Yy_plan>
    {
        public T_Yy_planMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Pname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Premarks)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.picurl)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.linkurl)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.rarec)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Yy_plan");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Pname).HasColumnName("Pname");
            this.Property(t => t.Premarks).HasColumnName("Premarks");
            this.Property(t => t.picurl).HasColumnName("picurl");
            this.Property(t => t.linkurl).HasColumnName("linkurl");
            this.Property(t => t.rarec).HasColumnName("rarec");
        }
    }
}
