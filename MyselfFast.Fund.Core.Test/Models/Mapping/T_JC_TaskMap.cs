using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.Collect.Core.Test.Models.Mapping
{
    public class T_JC_TaskMap : EntityTypeConfiguration<T_JC_Task>
    {
        public T_JC_TaskMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CollectlType)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Address_ID)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Description)
                .HasMaxLength(30);

            this.Property(t => t.OrderID)
                .HasMaxLength(30);

            this.Property(t => t.ShiKaiRate)
                .HasMaxLength(200);

            this.Property(t => t.NotShiKaiRate)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_JC_Task");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.WageAccuracy).HasColumnName("WageAccuracy");
            this.Property(t => t.CollectlType).HasColumnName("CollectlType");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Address_ID).HasColumnName("Address_ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.ShiKaiRate).HasColumnName("ShiKaiRate");
            this.Property(t => t.NotShiKaiRate).HasColumnName("NotShiKaiRate");
            this.Property(t => t.CollectProduct).HasColumnName("CollectProduct");
            this.Property(t => t.TaskType).HasColumnName("TaskType");
        }
    }
}
