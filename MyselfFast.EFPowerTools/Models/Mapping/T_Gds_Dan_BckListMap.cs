using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_Dan_BckListMap : EntityTypeConfiguration<T_Gds_Dan_BckList>
    {
        public T_Gds_Dan_BckListMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Parentno)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Orderno)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.QryParentno)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Usedname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PlanName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FenTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FenStans)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Hname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.AliasName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Ys1TypeName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Ys1Name)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Ys2TypeName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Ys2Name)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Opername)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Gds_Dan_BckList");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Parentid).HasColumnName("Parentid");
            this.Property(t => t.Orderid).HasColumnName("Orderid");
            this.Property(t => t.Parentno).HasColumnName("Parentno");
            this.Property(t => t.Orderno).HasColumnName("Orderno");
            this.Property(t => t.QryParentno).HasColumnName("QryParentno");
            this.Property(t => t.Tailid).HasColumnName("Tailid");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Usedname).HasColumnName("Usedname");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.PlanId).HasColumnName("PlanId");
            this.Property(t => t.PlanName).HasColumnName("PlanName");
            this.Property(t => t.FenType).HasColumnName("FenType");
            this.Property(t => t.FenTypeName).HasColumnName("FenTypeName");
            this.Property(t => t.FenStans).HasColumnName("FenStans");
            this.Property(t => t.Tid).HasColumnName("Tid");
            this.Property(t => t.Hname).HasColumnName("Hname");
            this.Property(t => t.AliasName).HasColumnName("AliasName");
            this.Property(t => t.Ys1TypeName).HasColumnName("Ys1TypeName");
            this.Property(t => t.Ys1).HasColumnName("Ys1");
            this.Property(t => t.Ys1Name).HasColumnName("Ys1Name");
            this.Property(t => t.Ys2TypeName).HasColumnName("Ys2TypeName");
            this.Property(t => t.Ys2).HasColumnName("Ys2");
            this.Property(t => t.Ys2Name).HasColumnName("Ys2Name");
            this.Property(t => t.Nums).HasColumnName("Nums");
            this.Property(t => t.Tnums).HasColumnName("Tnums");
            this.Property(t => t.BackMnypay).HasColumnName("BackMnypay");
            this.Property(t => t.BackFenpay).HasColumnName("BackFenpay");
            this.Property(t => t.BackCardpay).HasColumnName("BackCardpay");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.GenDate).HasColumnName("GenDate");
            this.Property(t => t.Oper).HasColumnName("Oper");
            this.Property(t => t.Opername).HasColumnName("Opername");
        }
    }
}
