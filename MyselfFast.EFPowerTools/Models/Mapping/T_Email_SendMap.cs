using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Email_SendMap : EntityTypeConfiguration<T_Email_Send>
    {
        public T_Email_SendMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.TITEL)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CONTENT)
                .IsRequired();

            this.Property(t => t.EMAIL)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Email_Send");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TITEL).HasColumnName("TITEL");
            this.Property(t => t.CONTENT).HasColumnName("CONTENT");
            this.Property(t => t.EMAIL).HasColumnName("EMAIL");
            this.Property(t => t.SENDTIME).HasColumnName("SENDTIME");
            this.Property(t => t.SENDSTATE).HasColumnName("SENDSTATE");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.PlanTime).HasColumnName("PlanTime");
        }
    }
}
