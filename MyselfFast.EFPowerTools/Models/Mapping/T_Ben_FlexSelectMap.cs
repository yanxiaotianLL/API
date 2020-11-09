using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Ben_FlexSelectMap : EntityTypeConfiguration<T_Ben_FlexSelect>
    {
        public T_Ben_FlexSelectMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Ben_FlexSelect");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PlanId).HasColumnName("PlanId");
            this.Property(t => t.FesID).HasColumnName("FesID");
            this.Property(t => t.Count).HasColumnName("Count");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.LastModifyTime).HasColumnName("LastModifyTime");
            this.Property(t => t.IsLock).HasColumnName("IsLock");
        }
    }
}
