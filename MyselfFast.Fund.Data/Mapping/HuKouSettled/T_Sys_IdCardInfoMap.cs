//
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using myselfFast.Fund.Core.Domain.HuKouSettled;

namespace myselfFast.Fund.Data.Mapping.HuKouSettled
{
    public class T_Sys_IdCardInfoMap : myselfFastEntityTypeConfiguration<T_Sys_IdCardInfo>
    {
        public T_Sys_IdCardInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CradName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CardId)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.CardGender)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.CardNation)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CardBirth)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Cardvalidate)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CardAuthority)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CardAddress)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ElecMatSource)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CardNationValue)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("T_Sys_IdCardInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.CradName).HasColumnName("CradName");
            this.Property(t => t.CardId).HasColumnName("CardId");
            this.Property(t => t.CardGender).HasColumnName("CardGender");
            this.Property(t => t.CardNation).HasColumnName("CardNation");
            this.Property(t => t.CardBirth).HasColumnName("CardBirth");
            this.Property(t => t.Cardvalidate).HasColumnName("Cardvalidate");
            this.Property(t => t.CardAuthority).HasColumnName("CardAuthority");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.CardAddress).HasColumnName("CardAddress");
            this.Property(t => t.OcrLevel).HasColumnName("OcrLevel");
            this.Property(t => t.ElecMatSource).HasColumnName("ElecMatSource");
            this.Property(t => t.CardNationValue).HasColumnName("CardNationValue");
        }
    }
}
