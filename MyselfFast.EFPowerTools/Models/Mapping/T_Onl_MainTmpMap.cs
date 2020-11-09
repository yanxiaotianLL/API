using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Onl_MainTmpMap : EntityTypeConfiguration<T_Onl_MainTmp>
    {
        public T_Onl_MainTmpMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ProveName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Onl_MainTmp");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ProveName).HasColumnName("ProveName");
        }
    }
}
