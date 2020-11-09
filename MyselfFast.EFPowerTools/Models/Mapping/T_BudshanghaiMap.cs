using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_BudshanghaiMap : EntityTypeConfiguration<T_Budshanghai>
    {
        public T_BudshanghaiMap()
        {
            // Primary Key
            this.HasKey(t => new { t.市, t.区, t.办公楼, t.拼音, t.地址, t.商圈 });

            // Properties
            this.Property(t => t.市)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.区)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.办公楼)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.拼音)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.地址)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.商圈)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("T_Budshanghai");
            this.Property(t => t.市).HasColumnName("市");
            this.Property(t => t.区).HasColumnName("区");
            this.Property(t => t.办公楼).HasColumnName("办公楼");
            this.Property(t => t.拼音).HasColumnName("拼音");
            this.Property(t => t.地址).HasColumnName("地址");
            this.Property(t => t.商圈).HasColumnName("商圈");
        }
    }
}
