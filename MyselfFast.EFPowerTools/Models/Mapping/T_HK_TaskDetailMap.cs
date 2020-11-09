using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_HK_TaskDetailMap : EntityTypeConfiguration<T_HK_TaskDetail>
    {
        public T_HK_TaskDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Remarks)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_HK_TaskDetail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Taskid).HasColumnName("Taskid");
            this.Property(t => t.Approveempid).HasColumnName("Approveempid");
            this.Property(t => t.Opertime).HasColumnName("Opertime");
            this.Property(t => t.Workflowid).HasColumnName("Workflowid");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
        }
    }
}
