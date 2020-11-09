using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Act_AppointmentProjectMap : EntityTypeConfiguration<T_Act_AppointmentProject>
    {
        public T_Act_AppointmentProjectMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Pname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Pindicatir)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Appname)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Act_AppointmentProject");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Pname).HasColumnName("Pname");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Pstu).HasColumnName("Pstu");
            this.Property(t => t.Ptime).HasColumnName("Ptime");
            this.Property(t => t.Pindicatir).HasColumnName("Pindicatir");
            this.Property(t => t.Pnum).HasColumnName("Pnum");
            this.Property(t => t.Appname).HasColumnName("Appname");
            this.Property(t => t.subtime).HasColumnName("subtime");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
        }
    }
}
