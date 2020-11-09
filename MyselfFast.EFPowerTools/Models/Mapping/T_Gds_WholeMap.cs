using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_WholeMap : EntityTypeConfiguration<T_Gds_Whole>
    {
        public T_Gds_WholeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Danno)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Addr)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Postcode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Bankseq)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Fapiaotitle)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Fapiaotype)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PiaoNumber)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Aplman)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Aplgonghao)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.PlanName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Fname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Script)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Yewubu)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.YewubuUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Bak)
                .IsRequired()
                .HasMaxLength(240);

            // Table & Column Mappings
            this.ToTable("T_Gds_Whole");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Danno).HasColumnName("Danno");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Busid).HasColumnName("Busid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Addr).HasColumnName("Addr");
            this.Property(t => t.Postcode).HasColumnName("Postcode");
            this.Property(t => t.Paytype).HasColumnName("Paytype");
            this.Property(t => t.SelPart).HasColumnName("SelPart");
            this.Property(t => t.ExtPart).HasColumnName("ExtPart");
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
            this.Property(t => t.PlanName).HasColumnName("PlanName");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.Interid).HasColumnName("Interid");
            this.Property(t => t.Source).HasColumnName("Source");
            this.Property(t => t.Fname).HasColumnName("Fname");
            this.Property(t => t.Script).HasColumnName("Script");
            this.Property(t => t.Yewubu).HasColumnName("Yewubu");
            this.Property(t => t.YewubuUser).HasColumnName("YewubuUser");
            this.Property(t => t.GdsTs).HasColumnName("GdsTs");
            this.Property(t => t.Bak).HasColumnName("Bak");
        }
    }
}
