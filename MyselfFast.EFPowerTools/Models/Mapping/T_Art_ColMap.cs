using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Art_ColMap : EntityTypeConfiguration<T_Art_Col>
    {
        public T_Art_ColMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Ctype)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Script)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Img)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Links)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("T_Art_Col");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Clubid).HasColumnName("Clubid");
            this.Property(t => t.Ctype).HasColumnName("Ctype");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Script).HasColumnName("Script");
            this.Property(t => t.Img).HasColumnName("Img");
            this.Property(t => t.Links).HasColumnName("Links");
            this.Property(t => t.Show).HasColumnName("Show");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
