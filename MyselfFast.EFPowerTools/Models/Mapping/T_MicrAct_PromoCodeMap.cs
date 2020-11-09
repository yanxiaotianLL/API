using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_MicrAct_PromoCodeMap : EntityTypeConfiguration<T_MicrAct_PromoCode>
    {
        public T_MicrAct_PromoCodeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.PromoCode)
                .HasMaxLength(200);

            this.Property(t => t.CreateUser)
                .HasMaxLength(50);

            this.Property(t => t.UpdateUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_MicrAct_PromoCode");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ActiveID).HasColumnName("ActiveID");
            this.Property(t => t.RegistrationID).HasColumnName("RegistrationID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.PromoCode).HasColumnName("PromoCode");
            this.Property(t => t.UseStatus).HasColumnName("UseStatus");
            this.Property(t => t.IssuedTime).HasColumnName("IssuedTime");
            this.Property(t => t.Val).HasColumnName("Val");
            this.Property(t => t.BeginDate).HasColumnName("BeginDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.IsSend).HasColumnName("IsSend");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.UpdateUser).HasColumnName("UpdateUser");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
        }
    }
}
