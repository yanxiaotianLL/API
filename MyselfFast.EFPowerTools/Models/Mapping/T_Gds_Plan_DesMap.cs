using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_Plan_DesMap : EntityTypeConfiguration<T_Gds_Plan_Des>
    {
        public T_Gds_Plan_DesMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.PlanName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(4000);

            // Table & Column Mappings
            this.ToTable("T_Gds_Plan_Des");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Planid).HasColumnName("Planid");
            this.Property(t => t.PlanName).HasColumnName("PlanName");
            this.Property(t => t.Hid).HasColumnName("Hid");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
