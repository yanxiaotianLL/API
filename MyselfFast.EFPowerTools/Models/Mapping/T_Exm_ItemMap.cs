using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_ItemMap : EntityTypeConfiguration<T_Exm_Item>
    {
        public T_Exm_ItemMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Content)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.Meaning)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Marry)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ClassName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Tag)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("T_Exm_Item");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Meaning).HasColumnName("Meaning");
            this.Property(t => t.PriceMarket).HasColumnName("PriceMarket");
            this.Property(t => t.PriceSales).HasColumnName("PriceSales");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Marry).HasColumnName("Marry");
            this.Property(t => t.ClassName).HasColumnName("ClassName");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.OperateTime).HasColumnName("OperateTime");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.PriceEmployee).HasColumnName("PriceEmployee");
            this.Property(t => t.Tag).HasColumnName("Tag");
        }
    }
}
