using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Onl_WorkexpMap : EntityTypeConfiguration<T_Onl_Workexp>
    {
        public T_Onl_WorkexpMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.UserType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CompName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Onl_Workexp");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Danid).HasColumnName("Danid");
            this.Property(t => t.UserType).HasColumnName("UserType");
            this.Property(t => t.BeginDate).HasColumnName("BeginDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.CompName).HasColumnName("CompName");
        }
    }
}
