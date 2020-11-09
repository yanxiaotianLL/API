using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Ocean_EmployeeBenefitsMap : EntityTypeConfiguration<T_Ocean_EmployeeBenefits>
    {
        public T_Ocean_EmployeeBenefitsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_Ocean_EmployeeBenefits");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.BirthdayBenefits).HasColumnName("BirthdayBenefits");
            this.Property(t => t.LaundryBenefits).HasColumnName("LaundryBenefits");
            this.Property(t => t.LaundryGoodLife).HasColumnName("LaundryGoodLife");
            this.Property(t => t.DragonBoatFestival).HasColumnName("DragonBoatFestival");
            this.Property(t => t.LaundryGoodLifezq).HasColumnName("LaundryGoodLifezq");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
