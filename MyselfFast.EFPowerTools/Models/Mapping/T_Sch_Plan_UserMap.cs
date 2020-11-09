using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sch_Plan_UserMap : EntityTypeConfiguration<T_Sch_Plan_User>
    {
        public T_Sch_Plan_UserMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Sch_Plan_User");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Planid).HasColumnName("Planid");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.SchNum).HasColumnName("SchNum");
            this.Property(t => t.Buynum).HasColumnName("Buynum");
            this.Property(t => t.LmtStart).HasColumnName("LmtStart");
            this.Property(t => t.LmtEnd).HasColumnName("LmtEnd");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
