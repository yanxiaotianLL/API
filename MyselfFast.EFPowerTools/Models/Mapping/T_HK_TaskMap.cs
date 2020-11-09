using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_HK_TaskMap : EntityTypeConfiguration<T_HK_Task>
    {
        public T_HK_TaskMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_HK_Task");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Approveempid).HasColumnName("Approveempid");
            this.Property(t => t.Opertime).HasColumnName("Opertime");
            this.Property(t => t.Workflowid).HasColumnName("Workflowid");
        }
    }
}
