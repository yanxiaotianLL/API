using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Ind_DetailMap : EntityTypeConfiguration<T_Ind_Detail>
    {
        public T_Ind_DetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FesName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BusiCustName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BusiDepName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.busiRepName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Ind_Detail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.FesName).HasColumnName("FesName");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.InductionType).HasColumnName("InductionType");
            this.Property(t => t.IsFirstLogin).HasColumnName("IsFirstLogin");
            this.Property(t => t.IndOrderId).HasColumnName("IndOrderId");
            this.Property(t => t.BusiDataId).HasColumnName("BusiDataId");
            this.Property(t => t.BusiCustId).HasColumnName("BusiCustId");
            this.Property(t => t.BusiCustName).HasColumnName("BusiCustName");
            this.Property(t => t.BusiDepName).HasColumnName("BusiDepName");
            this.Property(t => t.BusiDepId).HasColumnName("BusiDepId");
            this.Property(t => t.busiRepName).HasColumnName("busiRepName");
            this.Property(t => t.IndTaskId).HasColumnName("IndTaskId");
            this.Property(t => t.SenCondition).HasColumnName("SenCondition");
        }
    }
}
