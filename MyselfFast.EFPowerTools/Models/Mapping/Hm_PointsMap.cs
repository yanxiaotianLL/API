using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hm_PointsMap : EntityTypeConfiguration<Hm_Points>
    {
        public Hm_PointsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Hm_Points");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Points).HasColumnName("Points");
        }
    }
}
