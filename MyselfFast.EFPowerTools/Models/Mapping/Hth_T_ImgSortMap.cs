using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_ImgSortMap : EntityTypeConfiguration<Hth_T_ImgSort>
    {
        public Hth_T_ImgSortMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.DemoImg)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Hth_T_ImgSort");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.DemoImg).HasColumnName("DemoImg");
            this.Property(t => t.Must).HasColumnName("Must");
        }
    }
}
