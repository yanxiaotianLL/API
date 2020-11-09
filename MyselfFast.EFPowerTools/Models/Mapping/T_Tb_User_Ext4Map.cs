using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Tb_User_Ext4Map : EntityTypeConfiguration<T_Tb_User_Ext4>
    {
        public T_Tb_User_Ext4Map()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.婚姻状况)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.籍贯)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.联系电话)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.所在公司名称)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.迁出原因)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.迁往地地址)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.注销原因)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.去往国家)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_Tb_User_Ext4");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.婚姻状况).HasColumnName("婚姻状况");
            this.Property(t => t.出生日期).HasColumnName("出生日期");
            this.Property(t => t.籍贯).HasColumnName("籍贯");
            this.Property(t => t.联系电话).HasColumnName("联系电话");
            this.Property(t => t.所在公司名称).HasColumnName("所在公司名称");
            this.Property(t => t.迁出原因).HasColumnName("迁出原因");
            this.Property(t => t.迁往地地址).HasColumnName("迁往地地址");
            this.Property(t => t.注销原因).HasColumnName("注销原因");
            this.Property(t => t.去往国家).HasColumnName("去往国家");
            this.Property(t => t.落户日期).HasColumnName("落户日期");
            this.Property(t => t.迁出日期).HasColumnName("迁出日期");
        }
    }
}
