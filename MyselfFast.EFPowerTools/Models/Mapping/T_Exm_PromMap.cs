using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_PromMap : EntityTypeConfiguration<T_Exm_Prom>
    {
        public T_Exm_PromMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("T_Exm_Prom");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ProId).HasColumnName("ProId");
            this.Property(t => t.BeginTime).HasColumnName("BeginTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        }
    }
}
