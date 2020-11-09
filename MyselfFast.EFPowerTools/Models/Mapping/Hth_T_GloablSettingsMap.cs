using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_GloablSettingsMap : EntityTypeConfiguration<Hth_T_GloablSettings>
    {
        public Hth_T_GloablSettingsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Hth_T_GloablSettings");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UpdateDatetime).HasColumnName("UpdateDatetime");
            this.Property(t => t.GloablSwitch).HasColumnName("GloablSwitch");
        }
    }
}
