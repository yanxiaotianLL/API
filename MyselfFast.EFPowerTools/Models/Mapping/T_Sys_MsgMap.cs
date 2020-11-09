using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sys_MsgMap : EntityTypeConfiguration<T_Sys_Msg>
    {
        public T_Sys_MsgMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.PhoneNum)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.PhoneContent)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.ElectType)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ElectSource)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("T_Sys_Msg");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.PhoneNum).HasColumnName("PhoneNum");
            this.Property(t => t.PhoneContent).HasColumnName("PhoneContent");
            this.Property(t => t.ElectType).HasColumnName("ElectType");
            this.Property(t => t.ElectSource).HasColumnName("ElectSource");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.IsNowSend).HasColumnName("IsNowSend");
            this.Property(t => t.SendTime).HasColumnName("SendTime");
            this.Property(t => t.SendType).HasColumnName("SendType");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
        }
    }
}
