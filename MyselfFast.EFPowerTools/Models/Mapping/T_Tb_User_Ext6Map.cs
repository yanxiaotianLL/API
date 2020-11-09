using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Tb_User_Ext6Map : EntityTypeConfiguration<T_Tb_User_Ext6>
    {
        public T_Tb_User_Ext6Map()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.缴费人员类别)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Tb_User_Ext6");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Idx).HasColumnName("Idx");
            this.Property(t => t.缴费人员类别).HasColumnName("缴费人员类别");
            this.Property(t => t.四险缴费截止日期).HasColumnName("四险缴费截止日期");
            this.Property(t => t.医疗保险缴费截止日期).HasColumnName("医疗保险缴费截止日期");
            this.Property(t => t.住房公积金缴费截止日期).HasColumnName("住房公积金缴费截止日期");
            this.Property(t => t.是否缴纳过生育保险).HasColumnName("是否缴纳过生育保险");
            this.Property(t => t.是否已领取社会保障卡).HasColumnName("是否已领取社会保障卡");
        }
    }
}