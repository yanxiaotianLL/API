using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Email_insMap : EntityTypeConfiguration<T_Email_ins>
    {
        public T_Email_insMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.pc)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CreaterName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Email_ins");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Eid).HasColumnName("Eid");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.pc).HasColumnName("pc");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.SendType).HasColumnName("SendType");
            this.Property(t => t.PlanTime).HasColumnName("PlanTime");
            this.Property(t => t.CreaterId).HasColumnName("CreaterId");
            this.Property(t => t.CreaterName).HasColumnName("CreaterName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        }
    }
}
