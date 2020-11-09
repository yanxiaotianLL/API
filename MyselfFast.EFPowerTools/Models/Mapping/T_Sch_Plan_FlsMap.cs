using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sch_Plan_FlsMap : EntityTypeConfiguration<T_Sch_Plan_Fls>
    {
        public T_Sch_Plan_FlsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Sch_Plan_Fls");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Planid).HasColumnName("Planid");
            this.Property(t => t.Fid).HasColumnName("Fid");
        }
    }
}
