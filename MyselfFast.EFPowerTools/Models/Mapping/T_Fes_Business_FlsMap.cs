using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_Business_FlsMap : EntityTypeConfiguration<T_Fes_Business_Fls>
    {
        public T_Fes_Business_FlsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.custName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.busiCustName)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Fes_Business_Fls");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.custId).HasColumnName("custId");
            this.Property(t => t.custName).HasColumnName("custName");
            this.Property(t => t.busiCustId).HasColumnName("busiCustId");
            this.Property(t => t.busiCustName).HasColumnName("busiCustName");
            this.Property(t => t.HasMidical).HasColumnName("HasMidical");
        }
    }
}
