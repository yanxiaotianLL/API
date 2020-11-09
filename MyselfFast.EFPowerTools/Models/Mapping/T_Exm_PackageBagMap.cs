using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_PackageBagMap : EntityTypeConfiguration<T_Exm_PackageBag>
    {
        public T_Exm_PackageBagMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BriefInfo)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Year)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DuringTime)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_Exm_PackageBag");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Pay).HasColumnName("Pay");
            this.Property(t => t.BriefInfo).HasColumnName("BriefInfo");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.DuringTime).HasColumnName("DuringTime");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.CostPrice).HasColumnName("CostPrice");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
        }
    }
}
