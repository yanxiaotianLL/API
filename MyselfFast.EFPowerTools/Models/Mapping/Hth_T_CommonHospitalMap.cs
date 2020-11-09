using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_CommonHospitalMap : EntityTypeConfiguration<Hth_T_CommonHospital>
    {
        public Hth_T_CommonHospitalMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.Provice)
                .HasMaxLength(50);

            this.Property(t => t.City)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Hth_T_CommonHospital");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.H_ID).HasColumnName("H_ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Provice).HasColumnName("Provice");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.ModifyDate).HasColumnName("ModifyDate");
        }
    }
}
