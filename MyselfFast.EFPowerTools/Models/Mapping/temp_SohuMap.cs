using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class temp_SohuMap : EntityTypeConfiguration<temp_Sohu>
    {
        public temp_SohuMap()
        {
            // Primary Key
            this.HasKey(t => t.SNO);

            // Properties
            this.Property(t => t.SNO)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("temp_Sohu");
            this.Property(t => t.SNO).HasColumnName("SNO");
            this.Property(t => t.SDATE).HasColumnName("SDATE");
        }
    }
}
