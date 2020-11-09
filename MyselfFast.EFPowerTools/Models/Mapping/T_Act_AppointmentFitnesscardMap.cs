using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Act_AppointmentFitnesscardMap : EntityTypeConfiguration<T_Act_AppointmentFitnesscard>
    {
        public T_Act_AppointmentFitnesscardMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_Act_AppointmentFitnesscard");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Appid).HasColumnName("Appid");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.Ftime).HasColumnName("Ftime");
            this.Property(t => t.fstu).HasColumnName("fstu");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
        }
    }
}
