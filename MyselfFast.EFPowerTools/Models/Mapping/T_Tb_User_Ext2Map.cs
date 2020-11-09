using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Tb_User_Ext2Map : EntityTypeConfiguration<T_Tb_User_Ext2>
    {
        public T_Tb_User_Ext2Map()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.部号)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.组织机构代码)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.社会保险登记证编码)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.参加险种)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.民族)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.婚姻状况)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.文化程度)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.户口性质)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.户口所在区县街乡)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.户口所在地地址)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.户口所在地邮政编码)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.居住地联系地址)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.居住地邮政编码)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.选择邮寄社会保险对账单地址)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.账单地址邮政编码)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.参保人电话)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.个人身份)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.月均工资收入)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.缴费人员类别)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.医疗参保人员类别)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.农转工补缴单位名称)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.北京市工作居住证编码)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.委托代发基金银行名称)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.委托代发基金银行行号)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.委托代发基金银行帐号)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.委托代发银行行号)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.委托代发银行帐号)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.定点医疗机构1)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.定点医疗机构2)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.定点医疗机构3)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.定点医疗机构4)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.异地医院名称1)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.异地医院名称2)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.参保人签字)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.单位负责人)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.单位经办人)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.联系人姓名)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.联系人电话)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.填报单位)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.国籍)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.护照号码)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.外国居留证号码)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.外国人证件类型)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.外国人证件号)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.离退休类别)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.证件类型)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.港澳台居民往来内地通行证)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.获取对账单方式)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CAUSE)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_Tb_User_Ext2");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.唯一号).HasColumnName("唯一号");
            this.Property(t => t.部号).HasColumnName("部号");
            this.Property(t => t.组织机构代码).HasColumnName("组织机构代码");
            this.Property(t => t.社会保险登记证编码).HasColumnName("社会保险登记证编码");
            this.Property(t => t.参加险种).HasColumnName("参加险种");
            this.Property(t => t.民族).HasColumnName("民族");
            this.Property(t => t.婚姻状况).HasColumnName("婚姻状况");
            this.Property(t => t.文化程度).HasColumnName("文化程度");
            this.Property(t => t.户口性质).HasColumnName("户口性质");
            this.Property(t => t.户口所在区县街乡).HasColumnName("户口所在区县街乡");
            this.Property(t => t.户口所在地地址).HasColumnName("户口所在地地址");
            this.Property(t => t.户口所在地邮政编码).HasColumnName("户口所在地邮政编码");
            this.Property(t => t.居住地联系地址).HasColumnName("居住地联系地址");
            this.Property(t => t.居住地邮政编码).HasColumnName("居住地邮政编码");
            this.Property(t => t.选择邮寄社会保险对账单地址).HasColumnName("选择邮寄社会保险对账单地址");
            this.Property(t => t.账单地址邮政编码).HasColumnName("账单地址邮政编码");
            this.Property(t => t.参保人电话).HasColumnName("参保人电话");
            this.Property(t => t.参加工作日期).HasColumnName("参加工作日期");
            this.Property(t => t.个人身份).HasColumnName("个人身份");
            this.Property(t => t.月均工资收入).HasColumnName("月均工资收入");
            this.Property(t => t.缴费人员类别).HasColumnName("缴费人员类别");
            this.Property(t => t.医疗参保人员类别).HasColumnName("医疗参保人员类别");
            this.Property(t => t.农转工补缴单位名称).HasColumnName("农转工补缴单位名称");
            this.Property(t => t.是否患有特殊病).HasColumnName("是否患有特殊病");
            this.Property(t => t.北京市工作居住证编码).HasColumnName("北京市工作居住证编码");
            this.Property(t => t.证件有效截止日期).HasColumnName("证件有效截止日期");
            this.Property(t => t.委托代发基金银行名称).HasColumnName("委托代发基金银行名称");
            this.Property(t => t.委托代发基金银行行号).HasColumnName("委托代发基金银行行号");
            this.Property(t => t.委托代发基金银行帐号).HasColumnName("委托代发基金银行帐号");
            this.Property(t => t.委托代发银行行号).HasColumnName("委托代发银行行号");
            this.Property(t => t.委托代发银行帐号).HasColumnName("委托代发银行帐号");
            this.Property(t => t.定点医疗机构1).HasColumnName("定点医疗机构1");
            this.Property(t => t.定点医疗机构2).HasColumnName("定点医疗机构2");
            this.Property(t => t.定点医疗机构3).HasColumnName("定点医疗机构3");
            this.Property(t => t.定点医疗机构4).HasColumnName("定点医疗机构4");
            this.Property(t => t.异地安置日期).HasColumnName("异地安置日期");
            this.Property(t => t.异地医院名称1).HasColumnName("异地医院名称1");
            this.Property(t => t.异地医院名称2).HasColumnName("异地医院名称2");
            this.Property(t => t.参保人签字).HasColumnName("参保人签字");
            this.Property(t => t.参保人签字日期).HasColumnName("参保人签字日期");
            this.Property(t => t.单位负责人).HasColumnName("单位负责人");
            this.Property(t => t.单位经办人).HasColumnName("单位经办人");
            this.Property(t => t.填报日期).HasColumnName("填报日期");
            this.Property(t => t.办理日期).HasColumnName("办理日期");
            this.Property(t => t.联系人姓名).HasColumnName("联系人姓名");
            this.Property(t => t.联系人电话).HasColumnName("联系人电话");
            this.Property(t => t.填报单位).HasColumnName("填报单位");
            this.Property(t => t.出生日期).HasColumnName("出生日期");
            this.Property(t => t.Ischange).HasColumnName("Ischange");
            this.Property(t => t.国籍).HasColumnName("国籍");
            this.Property(t => t.护照号码).HasColumnName("护照号码");
            this.Property(t => t.外国居留证号码).HasColumnName("外国居留证号码");
            this.Property(t => t.外国人证件类型).HasColumnName("外国人证件类型");
            this.Property(t => t.外国人证件号).HasColumnName("外国人证件号");
            this.Property(t => t.离退休类别).HasColumnName("离退休类别");
            this.Property(t => t.离退休日期).HasColumnName("离退休日期");
            this.Property(t => t.证件类型).HasColumnName("证件类型");
            this.Property(t => t.港澳台居民往来内地通行证).HasColumnName("港澳台居民往来内地通行证");
            this.Property(t => t.获取对账单方式).HasColumnName("获取对账单方式");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CAUSE).HasColumnName("CAUSE");
        }
    }
}
