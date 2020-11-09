using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Act_AppointmentlimitMap : EntityTypeConfiguration<T_Act_Appointmentlimit>
    {
        public T_Act_AppointmentlimitMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Limitdate)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Act_Appointmentlimit");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Limitdate).HasColumnName("Limitdate");
            this.Property(t => t.Limitnum).HasColumnName("Limitnum");
        }
    }
}
