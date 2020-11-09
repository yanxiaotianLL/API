using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Report_BizCostMap : EntityTypeConfiguration<T_Report_BizCost>
    {
        public T_Report_BizCostMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CardId)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Fname)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Fno)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AccountDate)
                .IsRequired()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("T_Report_BizCost");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.CardId).HasColumnName("CardId");
            this.Property(t => t.Fname).HasColumnName("Fname");
            this.Property(t => t.Fno).HasColumnName("Fno");
            this.Property(t => t.PerBenefit).HasColumnName("PerBenefit");
            this.Property(t => t.BizCost).HasColumnName("BizCost");
            this.Property(t => t.PerCost).HasColumnName("PerCost");
            this.Property(t => t.BizScale).HasColumnName("BizScale");
            this.Property(t => t.PerScale).HasColumnName("PerScale");
            this.Property(t => t.BaseCost).HasColumnName("BaseCost");
            this.Property(t => t.Income).HasColumnName("Income");
            this.Property(t => t.MonthRate).HasColumnName("MonthRate");
            this.Property(t => t.YearRate).HasColumnName("YearRate");
            this.Property(t => t.AccountDate).HasColumnName("AccountDate");
            this.Property(t => t.OperateDate).HasColumnName("OperateDate");
        }
    }
}
