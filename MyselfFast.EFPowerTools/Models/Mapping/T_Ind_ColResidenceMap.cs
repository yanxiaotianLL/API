using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Ind_ColResidenceMap : EntityTypeConfiguration<T_Ind_ColResidence>
    {
        public T_Ind_ColResidenceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Ind_ColResidence");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
        }
    }
}
