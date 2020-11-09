using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_IsLookIndexMap : EntityTypeConfiguration<Hth_T_IsLookIndex>
    {
        public Hth_T_IsLookIndexMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Hth_T_IsLookIndex");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IsLook).HasColumnName("IsLook");
            this.Property(t => t.FesId).HasColumnName("FesId");
        }
    }
}
