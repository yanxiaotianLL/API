using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_IndExm_TempMap : EntityTypeConfiguration<T_IndExm_Temp>
    {
        public T_IndExm_TempMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ProdName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ProScheName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.TierCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TierName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.TierValue)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CreaterName)
                .HasMaxLength(50);

            this.Property(t => t.EditerName)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.SendMsg)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_IndExm_Temp");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ProdID).HasColumnName("ProdID");
            this.Property(t => t.ProdName).HasColumnName("ProdName");
            this.Property(t => t.ProScheID).HasColumnName("ProScheID");
            this.Property(t => t.ProScheName).HasColumnName("ProScheName");
            this.Property(t => t.TierCode).HasColumnName("TierCode");
            this.Property(t => t.TierName).HasColumnName("TierName");
            this.Property(t => t.TierValue).HasColumnName("TierValue");
            this.Property(t => t.UseState).HasColumnName("UseState");
            this.Property(t => t.CreaterName).HasColumnName("CreaterName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.EditerID).HasColumnName("EditerID");
            this.Property(t => t.EditerName).HasColumnName("EditerName");
            this.Property(t => t.EditTime).HasColumnName("EditTime");
            this.Property(t => t.Createrid).HasColumnName("Createrid");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.SendMsg).HasColumnName("SendMsg");
        }
    }
}
