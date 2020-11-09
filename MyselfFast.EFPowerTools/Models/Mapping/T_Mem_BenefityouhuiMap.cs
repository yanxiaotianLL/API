using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Mem_BenefityouhuiMap : EntityTypeConfiguration<T_Mem_Benefityouhui>
    {
        public T_Mem_BenefityouhuiMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Discount)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Depart)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Yewubuuser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Oper)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Mem_Benefityouhui");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.Depart).HasColumnName("Depart");
            this.Property(t => t.Yewubuuser).HasColumnName("Yewubuuser");
            this.Property(t => t.Oper).HasColumnName("Oper");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.Indate).HasColumnName("Indate");
            this.Property(t => t.Times).HasColumnName("Times");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
