using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_No_WakeMap : EntityTypeConfiguration<T_Gds_No_Wake>
    {
        public T_Gds_No_WakeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Gds_No_Wake");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Mid).HasColumnName("Mid");
            this.Property(t => t.Planid).HasColumnName("Planid");
            this.Property(t => t.Hid).HasColumnName("Hid");
        }
    }
}
