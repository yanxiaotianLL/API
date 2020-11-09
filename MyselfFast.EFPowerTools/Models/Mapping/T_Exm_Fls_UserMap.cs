using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_Fls_UserMap : EntityTypeConfiguration<T_Exm_Fls_User>
    {
        public T_Exm_Fls_UserMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Exm_Fls_User");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.IsCurrentUse).HasColumnName("IsCurrentUse");
            this.Property(t => t.OperateTime).HasColumnName("OperateTime");
        }
    }
}
