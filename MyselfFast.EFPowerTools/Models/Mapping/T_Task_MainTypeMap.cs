using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Task_MainTypeMap : EntityTypeConfiguration<T_Task_MainType>
    {
        public T_Task_MainTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Tasktype)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Task_MainType");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Tasktype).HasColumnName("Tasktype");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
            this.Property(t => t.OldId).HasColumnName("OldId");
        }
    }
}
