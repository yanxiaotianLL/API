using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Ind_ParOrgRelationMap : EntityTypeConfiguration<T_Ind_ParOrgRelation>
    {
        public T_Ind_ParOrgRelationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Ind_ParOrgRelation");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.PartyTime).HasColumnName("PartyTime");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
        }
    }
}
