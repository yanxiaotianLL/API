using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_UserverifyMap : EntityTypeConfiguration<T_Fes_Userverify>
    {
        public T_Fes_UserverifyMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CompanVerify)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.minzu)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.xueli)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.zhengzhimianmao)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.hukousuozaidi)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.dangansuozaidi)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.jishuzhicheng)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.xiangxidizhi)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.youzhengbianma)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.yidongdianhua)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.shebaorenyuanleibie)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.zaipaizhuangtai)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.shangshebianhao)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.fuzhubianhao)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.suozaigongsi)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.zhiwu)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.suoshuyewubu)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.yewuyuan)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.yewuyuanPhone)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.yewuyuanEmail)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.fuwuhetongyouxiaoqi)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.rudangshijian)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.xianyouzhiwujibie)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.zhiyezige)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.suozhudangzhibu)
                .IsRequired()
                .HasMaxLength(400);

            // Table & Column Mappings
            this.ToTable("T_Fes_Userverify");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Verify).HasColumnName("Verify");
            this.Property(t => t.SafeVerify).HasColumnName("SafeVerify");
            this.Property(t => t.MoreVerify).HasColumnName("MoreVerify");
            this.Property(t => t.CompanVerify).HasColumnName("CompanVerify");
            this.Property(t => t.minzu).HasColumnName("minzu");
            this.Property(t => t.xueli).HasColumnName("xueli");
            this.Property(t => t.zhengzhimianmao).HasColumnName("zhengzhimianmao");
            this.Property(t => t.hukousuozaidi).HasColumnName("hukousuozaidi");
            this.Property(t => t.dangansuozaidi).HasColumnName("dangansuozaidi");
            this.Property(t => t.jishuzhicheng).HasColumnName("jishuzhicheng");
            this.Property(t => t.xiangxidizhi).HasColumnName("xiangxidizhi");
            this.Property(t => t.youzhengbianma).HasColumnName("youzhengbianma");
            this.Property(t => t.yidongdianhua).HasColumnName("yidongdianhua");
            this.Property(t => t.shebaorenyuanleibie).HasColumnName("shebaorenyuanleibie");
            this.Property(t => t.zaipaizhuangtai).HasColumnName("zaipaizhuangtai");
            this.Property(t => t.shangshebianhao).HasColumnName("shangshebianhao");
            this.Property(t => t.fuzhubianhao).HasColumnName("fuzhubianhao");
            this.Property(t => t.suozaigongsi).HasColumnName("suozaigongsi");
            this.Property(t => t.zhiwu).HasColumnName("zhiwu");
            this.Property(t => t.suoshuyewubu).HasColumnName("suoshuyewubu");
            this.Property(t => t.yewuyuan).HasColumnName("yewuyuan");
            this.Property(t => t.yewuyuanPhone).HasColumnName("yewuyuanPhone");
            this.Property(t => t.yewuyuanEmail).HasColumnName("yewuyuanEmail");
            this.Property(t => t.fuwuhetongyouxiaoqi).HasColumnName("fuwuhetongyouxiaoqi");
            this.Property(t => t.rudangshijian).HasColumnName("rudangshijian");
            this.Property(t => t.shoucicanjiagongzuoshijian).HasColumnName("shoucicanjiagongzuoshijian");
            this.Property(t => t.xianyouzhiwujibie).HasColumnName("xianyouzhiwujibie");
            this.Property(t => t.zhiyezige).HasColumnName("zhiyezige");
            this.Property(t => t.jianligongjijinshijian).HasColumnName("jianligongjijinshijian");
            this.Property(t => t.suozhudangzhibu).HasColumnName("suozhudangzhibu");
            this.Property(t => t.wentifuli).HasColumnName("wentifuli");
            this.Property(t => t.duzifei).HasColumnName("duzifei");
        }
    }
}
