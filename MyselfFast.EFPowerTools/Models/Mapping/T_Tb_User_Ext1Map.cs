using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Tb_User_Ext1Map : EntityTypeConfiguration<T_Tb_User_Ext1>
    {
        public T_Tb_User_Ext1Map()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Uid)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.姓名)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.曾用名)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.学历)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.政治面貌)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.出生地)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.外聘公司)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.紧急联系人姓名)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.父亲姓名)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.母亲姓名)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.配偶姓名)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.配偶户籍地址)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.现在京详细住址)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.落户原因)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.配偶民族)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.子女姓名)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.血型)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.婚姻状况)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.民族)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.籍贯)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.紧急联系人电话)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.父母联系电话)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.父母户籍地址)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.配偶联系电话)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.现住址派出所)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.配偶身份证号)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.配偶学历)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.配偶公司)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.子女身份证号)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.性别)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.身份证号)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.联系电话)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.手机电话)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Tb_User_Ext1");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Uid).HasColumnName("Uid");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.曾用名).HasColumnName("曾用名");
            this.Property(t => t.学历).HasColumnName("学历");
            this.Property(t => t.政治面貌).HasColumnName("政治面貌");
            this.Property(t => t.出生地).HasColumnName("出生地");
            this.Property(t => t.外聘公司).HasColumnName("外聘公司");
            this.Property(t => t.紧急联系人姓名).HasColumnName("紧急联系人姓名");
            this.Property(t => t.父亲姓名).HasColumnName("父亲姓名");
            this.Property(t => t.母亲姓名).HasColumnName("母亲姓名");
            this.Property(t => t.配偶姓名).HasColumnName("配偶姓名");
            this.Property(t => t.配偶户籍地址).HasColumnName("配偶户籍地址");
            this.Property(t => t.现在京详细住址).HasColumnName("现在京详细住址");
            this.Property(t => t.落户原因).HasColumnName("落户原因");
            this.Property(t => t.结婚日期).HasColumnName("结婚日期");
            this.Property(t => t.配偶民族).HasColumnName("配偶民族");
            this.Property(t => t.配偶是否独生子女).HasColumnName("配偶是否独生子女");
            this.Property(t => t.子女姓名).HasColumnName("子女姓名");
            this.Property(t => t.血型).HasColumnName("血型");
            this.Property(t => t.婚姻状况).HasColumnName("婚姻状况");
            this.Property(t => t.民族).HasColumnName("民族");
            this.Property(t => t.身高).HasColumnName("身高");
            this.Property(t => t.是否独生子女).HasColumnName("是否独生子女");
            this.Property(t => t.籍贯).HasColumnName("籍贯");
            this.Property(t => t.身份证签发日期).HasColumnName("身份证签发日期");
            this.Property(t => t.紧急联系人电话).HasColumnName("紧急联系人电话");
            this.Property(t => t.父母联系电话).HasColumnName("父母联系电话");
            this.Property(t => t.父母户籍地址).HasColumnName("父母户籍地址");
            this.Property(t => t.配偶联系电话).HasColumnName("配偶联系电话");
            this.Property(t => t.现住址派出所).HasColumnName("现住址派出所");
            this.Property(t => t.配偶身份证号).HasColumnName("配偶身份证号");
            this.Property(t => t.配偶学历).HasColumnName("配偶学历");
            this.Property(t => t.配偶公司).HasColumnName("配偶公司");
            this.Property(t => t.子女身份证号).HasColumnName("子女身份证号");
            this.Property(t => t.出生日期).HasColumnName("出生日期");
            this.Property(t => t.性别).HasColumnName("性别");
            this.Property(t => t.身份证号).HasColumnName("身份证号");
            this.Property(t => t.联系电话).HasColumnName("联系电话");
            this.Property(t => t.手机电话).HasColumnName("手机电话");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Ischange).HasColumnName("Ischange");
        }
    }
}
