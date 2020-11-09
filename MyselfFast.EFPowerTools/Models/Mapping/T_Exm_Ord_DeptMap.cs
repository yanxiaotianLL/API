using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_Ord_DeptMap : EntityTypeConfiguration<T_Exm_Ord_Dept>
    {
        public T_Exm_Ord_DeptMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BizDept)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BizDeptSalesman)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SalesmanStatus)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.BizDeptId)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.BizDeptTypeVal)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CostCenterName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Exm_Ord_Dept");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Sid).HasColumnName("Sid");
            this.Property(t => t.BizDept).HasColumnName("BizDept");
            this.Property(t => t.BizDeptSalesman).HasColumnName("BizDeptSalesman");
            this.Property(t => t.SalesmanStatus).HasColumnName("SalesmanStatus");
            this.Property(t => t.SalesmanHno).HasColumnName("SalesmanHno");
            this.Property(t => t.BizDeptId).HasColumnName("BizDeptId");
            this.Property(t => t.BizDeptType).HasColumnName("BizDeptType");
            this.Property(t => t.BizDeptTypeVal).HasColumnName("BizDeptTypeVal");
            this.Property(t => t.IsSend).HasColumnName("IsSend");
            this.Property(t => t.CostCenterName).HasColumnName("CostCenterName");
            this.Property(t => t.OperateTime).HasColumnName("OperateTime");
        }
    }
}
