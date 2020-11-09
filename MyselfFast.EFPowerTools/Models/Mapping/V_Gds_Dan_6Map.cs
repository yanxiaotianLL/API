using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_Gds_Dan_6Map : EntityTypeConfiguration<V_Gds_Dan_6>
    {
        public V_Gds_Dan_6Map()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.ParentId, t.ParentNo, t.Danno, t.Fid, t.Busid, t.Fesid, t.Ftype, t.Addrid, t.Shouman, t.Shoultd, t.Sex, t.Provid, t.Prov, t.Xianid, t.Xian, t.Addr, t.Postcode, t.Mobile, t.Tel, t.Bak, t.ShouDayType, t.ShouTimeType, t.Paytype, t.Yuntype, t.Weight, t.Yunfei, t.MnyAll, t.Decfei, t.Mnypay, t.IsYouhui, t.Youhuicode, t.Gysid, t.GysName, t.Danstate, t.Dandate, t.Paydate, t.ConfirmDate, t.SendDate, t.Shoudate, t.Serv_Pleased, t.Kds_Pleased, t.Kdh_Pleased, t.Kd_Pleased, t.Goods_Pleased, t.Pjbak, t.Bak2, t.Pjstate, t.Bankseq, t.FapiaoState, t.Fapiaotitle, t.Fapiaotype, t.PiaoType, t.PiaoNumber, t.Passid, t.SoHuDanId, t.SoHuSouDate, t.SubDans, t.GdsTs, t.Danfei, t.Zifubao, t.Cardfei, t.State, t.Fenpay, t.Mtype, t.Aplman, t.Aplgonghao, t.Newdate, t.Juanid, t.Juan, t.Dstate, t.Tenid, t.Hisdanstate, t.Planid, t.BAK3, t.Email, t.IsSohuSendOk, t.IsSohuOkDate, t.OnceCardNum, t.Fname, t.Script, t.Source, t.Yewubu, t.YewubuUser, t.DanScript });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ParentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ParentNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Danno)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Busid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fesid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ftype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Addrid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Shouman)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Shoultd)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Provid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Prov)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Xianid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Xian)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Addr)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Postcode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Tel)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Bak)
                .IsRequired()
                .HasMaxLength(240);

            this.Property(t => t.ShouDayType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ShouTimeType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Paytype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Yuntype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Weight)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Yunfei)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MnyAll)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Decfei)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Mnypay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Youhuicode)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Gysid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GysName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Danstate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Serv_Pleased)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Kds_Pleased)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Kdh_Pleased)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Kd_Pleased)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Goods_Pleased)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Pjbak)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Bak2)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.Bankseq)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Fapiaotitle)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Fapiaotype)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PiaoType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PiaoNumber)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Passid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SoHuDanId)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SoHuSouDate)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SubDans)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GdsTs)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Danfei)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Zifubao)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Cardfei)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fenpay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Mtype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Aplman)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Aplgonghao)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Juanid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Juan)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Dstate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Tenid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Hisdanstate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Planid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BAK3)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.OnceCardNum)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cname)
                .HasMaxLength(200);

            this.Property(t => t.Ename)
                .HasMaxLength(800);

            this.Property(t => t.Usedname)
                .HasMaxLength(100);

            this.Property(t => t.Gno)
                .HasMaxLength(32);

            this.Property(t => t.CardId)
                .HasMaxLength(200);

            this.Property(t => t.UMobile)
                .HasMaxLength(200);

            this.Property(t => t.Fname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Script)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Source)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Yewubu)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.YewubuUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DanScript)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("V_Gds_Dan_6");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.ParentNo).HasColumnName("ParentNo");
            this.Property(t => t.Danno).HasColumnName("Danno");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Busid).HasColumnName("Busid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Ftype).HasColumnName("Ftype");
            this.Property(t => t.Addrid).HasColumnName("Addrid");
            this.Property(t => t.Shouman).HasColumnName("Shouman");
            this.Property(t => t.Shoultd).HasColumnName("Shoultd");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Provid).HasColumnName("Provid");
            this.Property(t => t.Prov).HasColumnName("Prov");
            this.Property(t => t.Xianid).HasColumnName("Xianid");
            this.Property(t => t.Xian).HasColumnName("Xian");
            this.Property(t => t.Addr).HasColumnName("Addr");
            this.Property(t => t.Postcode).HasColumnName("Postcode");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Bak).HasColumnName("Bak");
            this.Property(t => t.ShouDayType).HasColumnName("ShouDayType");
            this.Property(t => t.ShouTimeType).HasColumnName("ShouTimeType");
            this.Property(t => t.Paytype).HasColumnName("Paytype");
            this.Property(t => t.Yuntype).HasColumnName("Yuntype");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.Yunfei).HasColumnName("Yunfei");
            this.Property(t => t.MnyAll).HasColumnName("MnyAll");
            this.Property(t => t.Decfei).HasColumnName("Decfei");
            this.Property(t => t.Mnypay).HasColumnName("Mnypay");
            this.Property(t => t.IsYouhui).HasColumnName("IsYouhui");
            this.Property(t => t.Youhuicode).HasColumnName("Youhuicode");
            this.Property(t => t.Gysid).HasColumnName("Gysid");
            this.Property(t => t.GysName).HasColumnName("GysName");
            this.Property(t => t.Danstate).HasColumnName("Danstate");
            this.Property(t => t.Dandate).HasColumnName("Dandate");
            this.Property(t => t.Paydate).HasColumnName("Paydate");
            this.Property(t => t.ConfirmDate).HasColumnName("ConfirmDate");
            this.Property(t => t.SendDate).HasColumnName("SendDate");
            this.Property(t => t.Shoudate).HasColumnName("Shoudate");
            this.Property(t => t.Serv_Pleased).HasColumnName("Serv_Pleased");
            this.Property(t => t.Kds_Pleased).HasColumnName("Kds_Pleased");
            this.Property(t => t.Kdh_Pleased).HasColumnName("Kdh_Pleased");
            this.Property(t => t.Kd_Pleased).HasColumnName("Kd_Pleased");
            this.Property(t => t.Goods_Pleased).HasColumnName("Goods_Pleased");
            this.Property(t => t.Pjbak).HasColumnName("Pjbak");
            this.Property(t => t.Bak2).HasColumnName("Bak2");
            this.Property(t => t.Pjstate).HasColumnName("Pjstate");
            this.Property(t => t.Bankseq).HasColumnName("Bankseq");
            this.Property(t => t.FapiaoState).HasColumnName("FapiaoState");
            this.Property(t => t.Fapiaotitle).HasColumnName("Fapiaotitle");
            this.Property(t => t.Fapiaotype).HasColumnName("Fapiaotype");
            this.Property(t => t.PiaoType).HasColumnName("PiaoType");
            this.Property(t => t.PiaoNumber).HasColumnName("PiaoNumber");
            this.Property(t => t.Passid).HasColumnName("Passid");
            this.Property(t => t.SoHuDanId).HasColumnName("SoHuDanId");
            this.Property(t => t.SoHuSouDate).HasColumnName("SoHuSouDate");
            this.Property(t => t.SubDans).HasColumnName("SubDans");
            this.Property(t => t.GdsTs).HasColumnName("GdsTs");
            this.Property(t => t.Danfei).HasColumnName("Danfei");
            this.Property(t => t.Zifubao).HasColumnName("Zifubao");
            this.Property(t => t.Cardfei).HasColumnName("Cardfei");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Fenpay).HasColumnName("Fenpay");
            this.Property(t => t.Mtype).HasColumnName("Mtype");
            this.Property(t => t.Aplman).HasColumnName("Aplman");
            this.Property(t => t.Aplgonghao).HasColumnName("Aplgonghao");
            this.Property(t => t.Newdate).HasColumnName("Newdate");
            this.Property(t => t.Juanid).HasColumnName("Juanid");
            this.Property(t => t.Juan).HasColumnName("Juan");
            this.Property(t => t.Dstate).HasColumnName("Dstate");
            this.Property(t => t.Tenid).HasColumnName("Tenid");
            this.Property(t => t.Hisdanstate).HasColumnName("Hisdanstate");
            this.Property(t => t.Planid).HasColumnName("Planid");
            this.Property(t => t.BAK3).HasColumnName("BAK3");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.IsSohuSendOk).HasColumnName("IsSohuSendOk");
            this.Property(t => t.IsSohuOkDate).HasColumnName("IsSohuOkDate");
            this.Property(t => t.OnceCardNum).HasColumnName("OnceCardNum");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Ename).HasColumnName("Ename");
            this.Property(t => t.Usedname).HasColumnName("Usedname");
            this.Property(t => t.Gno).HasColumnName("Gno");
            this.Property(t => t.CardId).HasColumnName("CardId");
            this.Property(t => t.UMobile).HasColumnName("UMobile");
            this.Property(t => t.Expr1).HasColumnName("Expr1");
            this.Property(t => t.Fname).HasColumnName("Fname");
            this.Property(t => t.Script).HasColumnName("Script");
            this.Property(t => t.Source).HasColumnName("Source");
            this.Property(t => t.Yewubu).HasColumnName("Yewubu");
            this.Property(t => t.YewubuUser).HasColumnName("YewubuUser");
            this.Property(t => t.DanScript).HasColumnName("DanScript");
        }
    }
}
