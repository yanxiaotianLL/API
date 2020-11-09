using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_Pub_ColMap : EntityTypeConfiguration<T_Gds_Pub_Col>
    {
        public T_Gds_Pub_ColMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Gds_Pub_Col");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PlanId).HasColumnName("PlanId");
            this.Property(t => t.Hid).HasColumnName("Hid");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Xid).HasColumnName("Xid");
        }
    }
}
