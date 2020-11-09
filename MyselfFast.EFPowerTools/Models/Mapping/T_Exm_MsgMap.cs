using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_MsgMap : EntityTypeConfiguration<T_Exm_Msg>
    {
        public T_Exm_MsgMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.PersonMobile)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.MsgContent)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("T_Exm_Msg");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Checkuserid).HasColumnName("Checkuserid");
            this.Property(t => t.PersonMobile).HasColumnName("PersonMobile");
            this.Property(t => t.SendTime).HasColumnName("SendTime");
            this.Property(t => t.MsgContent).HasColumnName("MsgContent");
            this.Property(t => t.SendType).HasColumnName("SendType");
            this.Property(t => t.IsSend).HasColumnName("IsSend");
            this.Property(t => t.SubTime).HasColumnName("SubTime");
            this.Property(t => t.IsDel).HasColumnName("IsDel");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.checktype).HasColumnName("checktype");
        }
    }
}
