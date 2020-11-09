using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Tb_User_Ext3Map : EntityTypeConfiguration<T_Tb_User_Ext3>
    {
        public T_Tb_User_Ext3Map()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.再派出变更情况)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.联系电话)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.档案所在地)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.职称)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.个人简历)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.所具职业资格)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.住房情况)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.购房贷款种类)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.配偶身份证号)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.配偶户口所在地)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.子女姓名)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.子女性别)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.子女身份证)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.子女姓名2)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.子女性别2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.子女身份证2)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.聘用公司名称)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.民族)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.现居住详细地址)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.居住地邮政编码)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.工作居住证)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.户口性质)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.缴费人员类别)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.联系电话O)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.联系电话H)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.移动电话)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.户口所在地)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.政治面貌)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.现有学历学位)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.婚姻状况)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.现有职务级别)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.职位或职务)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.配偶姓名)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.配偶公司)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.配偶联系电话)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.国籍)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.电子邮箱)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.子女户口所在地)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.子女户口所在地2)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.工作经历)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.社会保险)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.配偶证件类型)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.子女证件类型)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.子女证件类型2)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Tb_User_Ext3");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.是否再派出).HasColumnName("是否再派出");
            this.Property(t => t.再派出变更情况).HasColumnName("再派出变更情况");
            this.Property(t => t.联系电话).HasColumnName("联系电话");
            this.Property(t => t.档案所在地).HasColumnName("档案所在地");
            this.Property(t => t.入党时间).HasColumnName("入党时间");
            this.Property(t => t.职称).HasColumnName("职称");
            this.Property(t => t.个人简历).HasColumnName("个人简历");
            this.Property(t => t.所具职业资格).HasColumnName("所具职业资格");
            this.Property(t => t.建公积金时间).HasColumnName("建公积金时间");
            this.Property(t => t.有无住房贷款).HasColumnName("有无住房贷款");
            this.Property(t => t.住房情况).HasColumnName("住房情况");
            this.Property(t => t.购房贷款种类).HasColumnName("购房贷款种类");
            this.Property(t => t.配偶是否已加入公积金).HasColumnName("配偶是否已加入公积金");
            this.Property(t => t.配偶身份证号).HasColumnName("配偶身份证号");
            this.Property(t => t.配偶户口所在地).HasColumnName("配偶户口所在地");
            this.Property(t => t.子女姓名).HasColumnName("子女姓名");
            this.Property(t => t.子女性别).HasColumnName("子女性别");
            this.Property(t => t.子女生日).HasColumnName("子女生日");
            this.Property(t => t.子女身份证).HasColumnName("子女身份证");
            this.Property(t => t.子女姓名2).HasColumnName("子女姓名2");
            this.Property(t => t.子女性别2).HasColumnName("子女性别2");
            this.Property(t => t.子女生日2).HasColumnName("子女生日2");
            this.Property(t => t.子女身份证2).HasColumnName("子女身份证2");
            this.Property(t => t.聘用公司名称).HasColumnName("聘用公司名称");
            this.Property(t => t.出生日期).HasColumnName("出生日期");
            this.Property(t => t.民族).HasColumnName("民族");
            this.Property(t => t.现居住详细地址).HasColumnName("现居住详细地址");
            this.Property(t => t.居住地邮政编码).HasColumnName("居住地邮政编码");
            this.Property(t => t.工作居住证).HasColumnName("工作居住证");
            this.Property(t => t.户口性质).HasColumnName("户口性质");
            this.Property(t => t.缴费人员类别).HasColumnName("缴费人员类别");
            this.Property(t => t.联系电话O).HasColumnName("联系电话O");
            this.Property(t => t.联系电话H).HasColumnName("联系电话H");
            this.Property(t => t.移动电话).HasColumnName("移动电话");
            this.Property(t => t.户口所在地).HasColumnName("户口所在地");
            this.Property(t => t.政治面貌).HasColumnName("政治面貌");
            this.Property(t => t.现有学历学位).HasColumnName("现有学历学位");
            this.Property(t => t.婚姻状况).HasColumnName("婚姻状况");
            this.Property(t => t.首次参加工作时间).HasColumnName("首次参加工作时间");
            this.Property(t => t.现有职务级别).HasColumnName("现有职务级别");
            this.Property(t => t.职位或职务).HasColumnName("职位或职务");
            this.Property(t => t.配偶姓名).HasColumnName("配偶姓名");
            this.Property(t => t.配偶公司).HasColumnName("配偶公司");
            this.Property(t => t.配偶联系电话).HasColumnName("配偶联系电话");
            this.Property(t => t.Ischanged).HasColumnName("Ischanged");
            this.Property(t => t.国籍).HasColumnName("国籍");
            this.Property(t => t.电子邮箱).HasColumnName("电子邮箱");
            this.Property(t => t.子女户口所在地).HasColumnName("子女户口所在地");
            this.Property(t => t.子女户口所在地2).HasColumnName("子女户口所在地2");
            this.Property(t => t.工作经历).HasColumnName("工作经历");
            this.Property(t => t.社会保险).HasColumnName("社会保险");
            this.Property(t => t.配偶证件类型).HasColumnName("配偶证件类型");
            this.Property(t => t.配偶生日).HasColumnName("配偶生日");
            this.Property(t => t.子女证件类型).HasColumnName("子女证件类型");
            this.Property(t => t.子女证件类型2).HasColumnName("子女证件类型2");
        }
    }
}
