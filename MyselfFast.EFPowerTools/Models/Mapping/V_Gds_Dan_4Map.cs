using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_Gds_Dan_4Map : EntityTypeConfiguration<V_Gds_Dan_4>
    {
        public V_Gds_Dan_4Map()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Danno, t.Fid, t.Busid, t.Fesid, t.Bak, t.Paytype, t.Decfei, t.Mnypay, t.Danstate, t.Dandate, t.Paydate, t.ConfirmDate, t.Bankseq, t.FapiaoState, t.Fapiaotitle, t.Fapiaotype, t.PiaoType, t.PiaoNumber, t.Aplman, t.Aplgonghao, t.Planid, t.Source, t.Yewubu, t.YewubuUser, t.DanScript });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Danno)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Busid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fesid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Bak)
                .IsRequired()
                .HasMaxLength(240);

            this.Property(t => t.Paytype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Decfei)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Mnypay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Danstate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.Aplman)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Aplgonghao)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Planid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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
                .HasMaxLength(100);

            this.Property(t => t.Script)
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
            this.ToTable("V_Gds_Dan_4");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Danno).HasColumnName("Danno");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Busid).HasColumnName("Busid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Bak).HasColumnName("Bak");
            this.Property(t => t.Paytype).HasColumnName("Paytype");
            this.Property(t => t.Decfei).HasColumnName("Decfei");
            this.Property(t => t.Mnypay).HasColumnName("Mnypay");
            this.Property(t => t.Danstate).HasColumnName("Danstate");
            this.Property(t => t.Dandate).HasColumnName("Dandate");
            this.Property(t => t.Paydate).HasColumnName("Paydate");
            this.Property(t => t.ConfirmDate).HasColumnName("ConfirmDate");
            this.Property(t => t.Bankseq).HasColumnName("Bankseq");
            this.Property(t => t.FapiaoState).HasColumnName("FapiaoState");
            this.Property(t => t.Fapiaotitle).HasColumnName("Fapiaotitle");
            this.Property(t => t.Fapiaotype).HasColumnName("Fapiaotype");
            this.Property(t => t.PiaoType).HasColumnName("PiaoType");
            this.Property(t => t.PiaoNumber).HasColumnName("PiaoNumber");
            this.Property(t => t.Aplman).HasColumnName("Aplman");
            this.Property(t => t.Aplgonghao).HasColumnName("Aplgonghao");
            this.Property(t => t.Planid).HasColumnName("Planid");
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
