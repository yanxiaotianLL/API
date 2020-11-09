using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_JurisdictionMap : EntityTypeConfiguration<Hth_T_Jurisdiction>
    {
        public Hth_T_JurisdictionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Note)
                .HasMaxLength(350);

            this.Property(t => t.PaperBillAmount)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Hth_T_Jurisdiction");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Pid).HasColumnName("Pid");
            this.Property(t => t.Custid).HasColumnName("Custid");
            this.Property(t => t.Busicustid).HasColumnName("Busicustid");
            this.Property(t => t.Conid).HasColumnName("Conid");
            this.Property(t => t.Acceid).HasColumnName("Acceid");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.HasHealth).HasColumnName("HasHealth");
            this.Property(t => t.IsExemptPaperBill).HasColumnName("IsExemptPaperBill");
            this.Property(t => t.PaperBillAmount).HasColumnName("PaperBillAmount");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.NoEntityCreateTime).HasColumnName("NoEntityCreateTime");
            this.Property(t => t.LimitTotalCount).HasColumnName("LimitTotalCount");
            this.Property(t => t.LimitTotalAmount).HasColumnName("LimitTotalAmount");
            this.Property(t => t.LimitIsEnable).HasColumnName("LimitIsEnable");
            this.Property(t => t.LimitCreateDate).HasColumnName("LimitCreateDate");
        }
    }
}
