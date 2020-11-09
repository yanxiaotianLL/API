using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_OrderDataMap : EntityTypeConfiguration<Hth_T_OrderData>
    {
        public Hth_T_OrderDataMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.DoUserDept)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CradNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SpouseHno)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SpouseName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SpouseDept)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RealName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Bank)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.BankAccount)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Hth_T_OrderData");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DoUserDeptId).HasColumnName("DoUserDeptId");
            this.Property(t => t.DoUserDept).HasColumnName("DoUserDept");
            this.Property(t => t.DoUserCom1).HasColumnName("DoUserCom1");
            this.Property(t => t.DoUserCom2).HasColumnName("DoUserCom2");
            this.Property(t => t.DoUserCom3).HasColumnName("DoUserCom3");
            this.Property(t => t.DoUserCom4).HasColumnName("DoUserCom4");
            this.Property(t => t.CradNo).HasColumnName("CradNo");
            this.Property(t => t.SpouseHno).HasColumnName("SpouseHno");
            this.Property(t => t.SpouseName).HasColumnName("SpouseName");
            this.Property(t => t.SpouseDept).HasColumnName("SpouseDept");
            this.Property(t => t.RealName).HasColumnName("RealName");
            this.Property(t => t.BankTypeId).HasColumnName("BankTypeId");
            this.Property(t => t.Bank).HasColumnName("Bank");
            this.Property(t => t.BankAccount).HasColumnName("BankAccount");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.YId).HasColumnName("YId");
            this.Property(t => t.KId).HasColumnName("KId");
            this.Property(t => t.SYId).HasColumnName("SYId");
            this.Property(t => t.SKId).HasColumnName("SKId");
            this.Property(t => t.MZProportion).HasColumnName("MZProportion");
            this.Property(t => t.SZProportion).HasColumnName("SZProportion");
            this.Property(t => t.CYId).HasColumnName("CYId");
            this.Property(t => t.BankId).HasColumnName("BankId");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.IsSendE).HasColumnName("IsSendE");
            this.Property(t => t.IsPart).HasColumnName("IsPart");
        }
    }
}
