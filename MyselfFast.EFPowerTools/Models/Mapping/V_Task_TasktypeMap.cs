using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_Task_TasktypeMap : EntityTypeConfiguration<V_Task_Tasktype>
    {
        public V_Task_TasktypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Typeid, t.Tasktype, t.SubId, t.Title, t.Script, t.WakeDays, t.Isdelete });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Typeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Tasktype)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SubId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Script)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.WakeDays)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("V_Task_Tasktype");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Typeid).HasColumnName("Typeid");
            this.Property(t => t.Tasktype).HasColumnName("Tasktype");
            this.Property(t => t.SubId).HasColumnName("SubId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Script).HasColumnName("Script");
            this.Property(t => t.WakeDays).HasColumnName("WakeDays");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
        }
    }
}
