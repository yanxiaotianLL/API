using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_HospitalMap : EntityTypeConfiguration<Hth_T_Hospital>
    {
        public Hth_T_HospitalMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.HosNo)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Hth_T_Hospital");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.PosId).HasColumnName("PosId");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.HosNo).HasColumnName("HosNo");
            this.Property(t => t.HosType).HasColumnName("HosType");
            this.Property(t => t.Note).HasColumnName("Note");
        }
    }
}
