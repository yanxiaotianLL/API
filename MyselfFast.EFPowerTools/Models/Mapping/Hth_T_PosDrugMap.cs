using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_PosDrugMap : EntityTypeConfiguration<Hth_T_PosDrug>
    {
        public Hth_T_PosDrugMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Hth_T_PosDrug");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DrugId).HasColumnName("DrugId");
            this.Property(t => t.PosId).HasColumnName("PosId");
            this.Property(t => t.Proportion).HasColumnName("Proportion");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        }
    }
}
