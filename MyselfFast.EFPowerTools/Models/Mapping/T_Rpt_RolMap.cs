using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Rpt_RolMap : EntityTypeConfiguration<T_Rpt_Rol>
    {
        public T_Rpt_RolMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Rpt_Rol");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RolId).HasColumnName("RolId");
            this.Property(t => t.DefId).HasColumnName("DefId");
        }
    }
}
