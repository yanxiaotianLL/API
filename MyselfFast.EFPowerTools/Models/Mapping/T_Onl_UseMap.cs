using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Onl_UseMap : EntityTypeConfiguration<T_Onl_Use>
    {
        public T_Onl_UseMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ProveUse)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Onl_Use");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.MTmpId).HasColumnName("MTmpId");
            this.Property(t => t.ProveUse).HasColumnName("ProveUse");
        }
    }
}
