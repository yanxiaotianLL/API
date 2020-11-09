using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_MicrAct_PromoCodeMap : EntityTypeConfiguration<V_MicrAct_PromoCode>
    {
        public V_MicrAct_PromoCodeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Hno, t.Cname, t.Ename, t.Usedname, t.Gno, t.CardId, t.Mobile });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PromoCode)
                .HasMaxLength(200);

            this.Property(t => t.CreateUser)
                .HasMaxLength(50);

            this.Property(t => t.UpdateUser)
                .HasMaxLength(50);

            this.Property(t => t.Hno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Ename)
                .IsRequired()
                .HasMaxLength(800);

            this.Property(t => t.Usedname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Gno)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CardId)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("V_MicrAct_PromoCode");
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
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Ename).HasColumnName("Ename");
            this.Property(t => t.Usedname).HasColumnName("Usedname");
            this.Property(t => t.Gno).HasColumnName("Gno");
            this.Property(t => t.CardId).HasColumnName("CardId");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
        }
    }
}
