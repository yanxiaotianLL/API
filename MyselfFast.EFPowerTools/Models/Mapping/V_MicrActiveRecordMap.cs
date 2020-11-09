using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_MicrActiveRecordMap : EntityTypeConfiguration<V_MicrActiveRecord>
    {
        public V_MicrActiveRecordMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.HealthActiveType });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PromoCode)
                .HasMaxLength(50);

            this.Property(t => t.JoinPerson)
                .HasMaxLength(200);

            this.Property(t => t.BillContent)
                .HasMaxLength(500);

            this.Property(t => t.BillReceiveTel)
                .HasMaxLength(20);

            this.Property(t => t.BillReceiver)
                .HasMaxLength(50);

            this.Property(t => t.BillSendAddress)
                .HasMaxLength(200);

            this.Property(t => t.BillTitle)
                .HasMaxLength(200);

            this.Property(t => t.subMicrPic)
                .HasMaxLength(500);

            this.Property(t => t.subActiveName)
                .HasMaxLength(200);

            this.Property(t => t.ActiveAddress)
                .HasMaxLength(500);

            this.Property(t => t.mainMicrPic)
                .HasMaxLength(500);

            this.Property(t => t.mainActiveName)
                .HasMaxLength(200);

            this.Property(t => t.HealthActiveType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("V_MicrActiveRecord");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ActiveID).HasColumnName("ActiveID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Fenday).HasColumnName("Fenday");
            this.Property(t => t.Pubtime).HasColumnName("Pubtime");
            this.Property(t => t.ParentActiveID).HasColumnName("ParentActiveID");
            this.Property(t => t.PromoCode).HasColumnName("PromoCode");
            this.Property(t => t.JoinPerson).HasColumnName("JoinPerson");
            this.Property(t => t.Totalpay).HasColumnName("Totalpay");
            this.Property(t => t.ApplyStatus).HasColumnName("ApplyStatus");
            this.Property(t => t.BillContent).HasColumnName("BillContent");
            this.Property(t => t.BillReceiveTel).HasColumnName("BillReceiveTel");
            this.Property(t => t.BillReceiver).HasColumnName("BillReceiver");
            this.Property(t => t.BillSendAddress).HasColumnName("BillSendAddress");
            this.Property(t => t.BillTitle).HasColumnName("BillTitle");
            this.Property(t => t.subMicrPic).HasColumnName("subMicrPic");
            this.Property(t => t.subActiveName).HasColumnName("subActiveName");
            this.Property(t => t.ActiveAddress).HasColumnName("ActiveAddress");
            this.Property(t => t.Ischarge).HasColumnName("Ischarge");
            this.Property(t => t.mainMicrPic).HasColumnName("mainMicrPic");
            this.Property(t => t.mainActiveName).HasColumnName("mainActiveName");
            this.Property(t => t.IsSubActive).HasColumnName("IsSubActive");
            this.Property(t => t.ActiveFrom).HasColumnName("ActiveFrom");
            this.Property(t => t.HealthActiveType).HasColumnName("HealthActiveType");
        }
    }
}
