using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Act_AppointmentMap : EntityTypeConfiguration<T_Act_Appointment>
    {
        public T_Act_AppointmentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Username)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Usercname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Orderid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Sort)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Timezone)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Content)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Dept)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Act_Appointment");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Userkey).HasColumnName("Userkey");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.Usercname).HasColumnName("Usercname");
            this.Property(t => t.Orderid).HasColumnName("Orderid");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.Apptime).HasColumnName("Apptime");
            this.Property(t => t.Timezone).HasColumnName("Timezone");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Pubtime).HasColumnName("Pubtime");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Donestatus).HasColumnName("Donestatus");
            this.Property(t => t.Dept).HasColumnName("Dept");
        }
    }
}
