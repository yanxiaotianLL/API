using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_HK_BussinessItemMap : EntityTypeConfiguration<T_HK_BussinessItem>
    {
        public T_HK_BussinessItemMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BussinessName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_HK_BussinessItem");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.ItemFee).HasColumnName("ItemFee");
            this.Property(t => t.BussinessName).HasColumnName("BussinessName");
        }
    }
}
