using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sch_Zheng_InterfaceMap : EntityTypeConfiguration<T_Sch_Zheng_Interface>
    {
        public T_Sch_Zheng_InterfaceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Sch_Zheng_Interface");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.MainPlanid).HasColumnName("MainPlanid");
            this.Property(t => t.Subtime).HasColumnName("Subtime");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
