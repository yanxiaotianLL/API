using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.Collect.Core.Test.Models.Mapping
{
    public class T_FundBussinessNameMap : EntityTypeConfiguration<T_FundBussinessName>
    {
        public T_FundBussinessNameMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.UNIT_NO)
                .HasMaxLength(30);

            this.Property(t => t.UNIT_NAME_PRINT)
                .HasMaxLength(50);

            this.Property(t => t.BUSI_CUST_NO)
                .HasMaxLength(30);

            this.Property(t => t.BUSI_CUST_NAME)
                .HasMaxLength(50);

            this.Property(t => t.OptAccount)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("T_FundBussinessName");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UNIT_NO).HasColumnName("UNIT_NO");
            this.Property(t => t.UNIT_NAME_PRINT).HasColumnName("UNIT_NAME_PRINT");
            this.Property(t => t.BUSI_CUST_NO).HasColumnName("BUSI_CUST_NO");
            this.Property(t => t.BUSI_CUST_NAME).HasColumnName("BUSI_CUST_NAME");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.OptAccount).HasColumnName("OptAccount");
        }
    }
}
