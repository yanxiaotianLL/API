using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Ben_Plan_ExtendMap : EntityTypeConfiguration<T_Ben_Plan_Extend>
    {
        public T_Ben_Plan_ExtendMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Addr)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ZipCode)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("T_Ben_Plan_Extend");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.Planid).HasColumnName("Planid");
            this.Property(t => t.Addr).HasColumnName("Addr");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
        }
    }
}
