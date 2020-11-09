using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_S_SetAuditMap : EntityTypeConfiguration<Hth_S_SetAudit>
    {
        public Hth_S_SetAuditMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Hth_S_SetAudit");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.SysUserId).HasColumnName("SysUserId");
            this.Property(t => t.AuType).HasColumnName("AuType");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.OperState).HasColumnName("OperState");
        }
    }
}
