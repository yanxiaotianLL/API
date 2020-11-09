using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_CostImgSortMap : EntityTypeConfiguration<Hth_T_CostImgSort>
    {
        public Hth_T_CostImgSortMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Hth_T_CostImgSort");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CostId).HasColumnName("CostId");
            this.Property(t => t.ImgSort).HasColumnName("ImgSort");
            this.Property(t => t.CType).HasColumnName("CType");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
