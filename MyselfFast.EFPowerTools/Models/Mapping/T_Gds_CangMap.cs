using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_CangMap : EntityTypeConfiguration<T_Gds_Cang>
    {
        public T_Gds_CangMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Gds_Cang");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Planid).HasColumnName("Planid");
            this.Property(t => t.Tid).HasColumnName("Tid");
        }
    }
}
