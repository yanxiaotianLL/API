using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Email_BirthdayMap : EntityTypeConfiguration<T_Email_Birthday>
    {
        public T_Email_BirthdayMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Email_Birthday");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Eid).HasColumnName("Eid");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.BeforeDay).HasColumnName("BeforeDay");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.LastExecutionDate).HasColumnName("LastExecutionDate");
        }
    }
}
