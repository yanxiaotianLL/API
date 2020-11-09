using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_IndExm_MailMap : EntityTypeConfiguration<T_IndExm_Mail>
    {
        public T_IndExm_MailMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ReceiveUser)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.EType)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("T_IndExm_Mail");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UID).HasColumnName("UID");
            this.Property(t => t.ReceiveUser).HasColumnName("ReceiveUser");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.LatestSendTime).HasColumnName("LatestSendTime");
            this.Property(t => t.IsAllow).HasColumnName("IsAllow");
            this.Property(t => t.SendCount).HasColumnName("SendCount");
            this.Property(t => t.EType).HasColumnName("EType");
            this.Property(t => t.EState).HasColumnName("EState");
        }
    }
}
