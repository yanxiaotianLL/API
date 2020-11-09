using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Task_TypeMap : EntityTypeConfiguration<T_Task_Type>
    {
        public T_Task_TypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Typeid, t.SubId });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Typeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SubId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Script)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("T_Task_Type");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Typeid).HasColumnName("Typeid");
            this.Property(t => t.SubId).HasColumnName("SubId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Script).HasColumnName("Script");
            this.Property(t => t.WakeDays).HasColumnName("WakeDays");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
            this.Property(t => t.OldId).HasColumnName("OldId");
        }
    }
}
