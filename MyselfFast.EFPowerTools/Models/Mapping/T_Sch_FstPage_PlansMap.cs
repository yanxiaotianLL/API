using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sch_FstPage_PlansMap : EntityTypeConfiguration<T_Sch_FstPage_Plans>
    {
        public T_Sch_FstPage_PlansMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Sch_FstPage_Plans");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Planid).HasColumnName("Planid");
        }
    }
}
