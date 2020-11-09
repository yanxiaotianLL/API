using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.Collect.Core.Test.Models.Mapping
{
    public class T_JC_TaskUnitMap : EntityTypeConfiguration<T_JC_TaskUnit>
    {
        public T_JC_TaskUnitMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CON_ACCE_ID)
                .HasMaxLength(20);

            this.Property(t => t.BUSI_CUST_NO)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.UNIT_NO)
                .HasMaxLength(30);

            this.Property(t => t.Address_ID)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Address)
                .HasMaxLength(20);

            this.Property(t => t.AccountName)
                .HasMaxLength(30);

            this.Property(t => t.CONT_NO)
                .HasMaxLength(30);

            this.Property(t => t.ACCE_NO)
                .HasMaxLength(30);

            this.Property(t => t.SUPP_NO)
                .HasMaxLength(30);

            this.Property(t => t.AuditingAccountName)
                .HasMaxLength(20);

            this.Property(t => t.CollectionTableNo)
                .HasMaxLength(30);

            this.Property(t => t.CollectlType)
                .HasMaxLength(20);

            this.Property(t => t.ShiKaiRate)
                .HasMaxLength(20);

            this.Property(t => t.NotShiKaiRate)
                .HasMaxLength(20);

            this.Property(t => t.SheBaoCapValue)
                .HasMaxLength(20);

            this.Property(t => t.GongJiJinCapValue)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("T_JC_TaskUnit");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CON_ACCE_ID).HasColumnName("CON_ACCE_ID");
            this.Property(t => t.BUSI_CUST_NO).HasColumnName("BUSI_CUST_NO");
            this.Property(t => t.UNIT_NO).HasColumnName("UNIT_NO");
            this.Property(t => t.Address_ID).HasColumnName("Address_ID");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.AccountID).HasColumnName("AccountID");
            this.Property(t => t.AccountName).HasColumnName("AccountName");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.TaskId).HasColumnName("TaskId");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CONT_NO).HasColumnName("CONT_NO");
            this.Property(t => t.ACCE_NO).HasColumnName("ACCE_NO");
            this.Property(t => t.SUPP_NO).HasColumnName("SUPP_NO");
            this.Property(t => t.IsNeedCollectTable).HasColumnName("IsNeedCollectTable");
            this.Property(t => t.IsNeedAuditing).HasColumnName("IsNeedAuditing");
            this.Property(t => t.AuditingState).HasColumnName("AuditingState");
            this.Property(t => t.AuditingAccountName).HasColumnName("AuditingAccountName");
            this.Property(t => t.AuditingAccountID).HasColumnName("AuditingAccountID");
            this.Property(t => t.CollectionTableNo).HasColumnName("CollectionTableNo");
            this.Property(t => t.CollectlType).HasColumnName("CollectlType");
            this.Property(t => t.CollectlProduct).HasColumnName("CollectlProduct");
            this.Property(t => t.ShiKaiRate).HasColumnName("ShiKaiRate");
            this.Property(t => t.NotShiKaiRate).HasColumnName("NotShiKaiRate");
            this.Property(t => t.SheBaoCapValue).HasColumnName("SheBaoCapValue");
            this.Property(t => t.GongJiJinCapValue).HasColumnName("GongJiJinCapValue");
        }
    }
}
