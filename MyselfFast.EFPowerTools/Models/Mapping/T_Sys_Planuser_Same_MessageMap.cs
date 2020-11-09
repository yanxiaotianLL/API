using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sys_Planuser_Same_MessageMap : EntityTypeConfiguration<T_Sys_Planuser_Same_Message>
    {
        public T_Sys_Planuser_Same_MessageMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Message)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Sys_Planuser_Same_Message");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Linkid).HasColumnName("Linkid");
            this.Property(t => t.Checkdate).HasColumnName("Checkdate");
            this.Property(t => t.Gendate).HasColumnName("Gendate");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Message).HasColumnName("Message");
        }
    }
}
