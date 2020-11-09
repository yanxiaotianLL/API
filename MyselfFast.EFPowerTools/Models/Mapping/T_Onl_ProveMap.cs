using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Onl_ProveMap : EntityTypeConfiguration<T_Onl_Prove>
    {
        public T_Onl_ProveMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.OrderNo)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.ScName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BsName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PayTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PayAccount)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AddrStr)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.AddrStrTag)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.StateName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PiaoTitle)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PiaoUse)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Tails)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.CancelMemo)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Kno)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Alipayno)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PiaoNumber)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("T_Onl_Prove");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.OrderNo).HasColumnName("OrderNo");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.ScId).HasColumnName("ScId");
            this.Property(t => t.ScName).HasColumnName("ScName");
            this.Property(t => t.BsName).HasColumnName("BsName");
            this.Property(t => t.FName).HasColumnName("FName");
            this.Property(t => t.GenDate).HasColumnName("GenDate");
            this.Property(t => t.PayTypeid).HasColumnName("PayTypeid");
            this.Property(t => t.PayTypeName).HasColumnName("PayTypeName");
            this.Property(t => t.PayDate).HasColumnName("PayDate");
            this.Property(t => t.PayAccount).HasColumnName("PayAccount");
            this.Property(t => t.PayMoney).HasColumnName("PayMoney");
            this.Property(t => t.AccDate).HasColumnName("AccDate");
            this.Property(t => t.AddrId).HasColumnName("AddrId");
            this.Property(t => t.AddrStr).HasColumnName("AddrStr");
            this.Property(t => t.AddrStrTag).HasColumnName("AddrStrTag");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.StateName).HasColumnName("StateName");
            this.Property(t => t.PiaoState).HasColumnName("PiaoState");
            this.Property(t => t.PiaoTitle).HasColumnName("PiaoTitle");
            this.Property(t => t.PiaoUse).HasColumnName("PiaoUse");
            this.Property(t => t.PrintState).HasColumnName("PrintState");
            this.Property(t => t.PrintDate).HasColumnName("PrintDate");
            this.Property(t => t.Tails).HasColumnName("Tails");
            this.Property(t => t.CancelMemo).HasColumnName("CancelMemo");
            this.Property(t => t.Kno).HasColumnName("Kno");
            this.Property(t => t.Alipayno).HasColumnName("Alipayno");
            this.Property(t => t.PiaoType).HasColumnName("PiaoType");
            this.Property(t => t.PiaoNumber).HasColumnName("PiaoNumber");
        }
    }
}
