using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_SendMsgTelMap : EntityTypeConfiguration<T_SendMsgTel>
    {
        public T_SendMsgTelMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TelName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TelNumber)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_SendMsgTel");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TelName).HasColumnName("TelName");
            this.Property(t => t.TelNumber).HasColumnName("TelNumber");
            this.Property(t => t.Createtime).HasColumnName("Createtime");
            this.Property(t => t.Hno).HasColumnName("Hno");
        }
    }
}
