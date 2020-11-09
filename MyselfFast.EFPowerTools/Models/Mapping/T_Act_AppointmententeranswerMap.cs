using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Act_AppointmententeranswerMap : EntityTypeConfiguration<T_Act_Appointmententeranswer>
    {
        public T_Act_AppointmententeranswerMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Username)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Enteranswer)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Act_Appointmententeranswer");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Enteranswer).HasColumnName("Enteranswer");
        }
    }
}
