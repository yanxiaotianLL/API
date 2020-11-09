//
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using myselfFast.Fund.Core.Domain.Hukou;
using myselfFast.Fund.Core.Domain;

namespace myselfFast.Fund.Data.Mapping.Hukou
{
    public class T_Helo_MsgLogMap : myselfFastEntityTypeConfiguration<T_Helo_MsgLog>
    {
      public T_Helo_MsgLogMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.MobileNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MsgContent)
                .IsRequired()
                .HasMaxLength(800);

            this.Property(t => t.errorContent)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.ElectType)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ElectSource)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LinkId)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Helo_MsgLog");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.MobileNo).HasColumnName("MobileNo");
            this.Property(t => t.Sendtime).HasColumnName("Sendtime");
            this.Property(t => t.TrySendtime).HasColumnName("TrySendtime");
            this.Property(t => t.TryTimes).HasColumnName("TryTimes");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.isNeedTry).HasColumnName("isNeedTry");
            this.Property(t => t.MsgContent).HasColumnName("MsgContent");
            this.Property(t => t.errorContent).HasColumnName("errorContent");
            this.Property(t => t.IsDel).HasColumnName("IsDel");
            this.Property(t => t.ElectType).HasColumnName("ElectType");
            this.Property(t => t.ElectSource).HasColumnName("ElectSource");
            this.Property(t => t.IsNowSend).HasColumnName("IsNowSend");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.LinkId).HasColumnName("LinkId");
        }
    }
}
