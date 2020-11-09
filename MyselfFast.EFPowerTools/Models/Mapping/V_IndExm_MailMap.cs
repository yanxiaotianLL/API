using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_IndExm_MailMap : EntityTypeConfiguration<V_IndExm_Mail>
    {
        public V_IndExm_MailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.UID, t.ReceiveUser, t.CreateTime, t.LatestSendTime, t.IsAllow, t.SendCount, t.EType, t.EState, t.PartId, t.CheckNo, t.PersonName, t.ChooseJigou, t.WriteDate });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReceiveUser)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.SendCount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EType)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.EState)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PartId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CheckNo)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.PersonName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ChooseJigou)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("V_IndExm_Mail");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UID).HasColumnName("UID");
            this.Property(t => t.ReceiveUser).HasColumnName("ReceiveUser");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.LatestSendTime).HasColumnName("LatestSendTime");
            this.Property(t => t.IsAllow).HasColumnName("IsAllow");
            this.Property(t => t.SendCount).HasColumnName("SendCount");
            this.Property(t => t.EType).HasColumnName("EType");
            this.Property(t => t.EState).HasColumnName("EState");
            this.Property(t => t.PartId).HasColumnName("PartId");
            this.Property(t => t.CheckNo).HasColumnName("CheckNo");
            this.Property(t => t.PersonName).HasColumnName("PersonName");
            this.Property(t => t.ChooseJigou).HasColumnName("ChooseJigou");
            this.Property(t => t.WriteDate).HasColumnName("WriteDate");
        }
    }
}
