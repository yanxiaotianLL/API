using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_BaseMap : EntityTypeConfiguration<T_Gds_Base>
    {
        public T_Gds_BaseMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.GysJiancheng)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Gysname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Numbers)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Ename)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.AliasName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.AliasEName)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Stand)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Model)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Product)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Ysname)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Ysname2)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Mcname)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Jianj)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.Content)
                .IsRequired();

            this.Property(t => t.Attention)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.AskCause)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.AskBack)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CardRule)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.DealRule)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Ext1)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Ext2)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Ext3)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Ext4)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Ext5)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Ext6)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.RoleName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.OperName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Calculation)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("T_Gds_Base");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Gysid).HasColumnName("Gysid");
            this.Property(t => t.GysJiancheng).HasColumnName("GysJiancheng");
            this.Property(t => t.Gysname).HasColumnName("Gysname");
            this.Property(t => t.Numbers).HasColumnName("Numbers");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Ename).HasColumnName("Ename");
            this.Property(t => t.AliasName).HasColumnName("AliasName");
            this.Property(t => t.AliasEName).HasColumnName("AliasEName");
            this.Property(t => t.Stand).HasColumnName("Stand");
            this.Property(t => t.Model).HasColumnName("Model");
            this.Property(t => t.Product).HasColumnName("Product");
            this.Property(t => t.Ysname).HasColumnName("Ysname");
            this.Property(t => t.Ysname2).HasColumnName("Ysname2");
            this.Property(t => t.Mcid).HasColumnName("Mcid");
            this.Property(t => t.Mcname).HasColumnName("Mcname");
            this.Property(t => t.Jianj).HasColumnName("Jianj");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Tuiable).HasColumnName("Tuiable");
            this.Property(t => t.Attention).HasColumnName("Attention");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.IsUsed).HasColumnName("IsUsed");
            this.Property(t => t.PubToFescoDate).HasColumnName("PubToFescoDate");
            this.Property(t => t.DownFromGysDate).HasColumnName("DownFromGysDate");
            this.Property(t => t.SelectByFescoDate).HasColumnName("SelectByFescoDate");
            this.Property(t => t.Askdelete).HasColumnName("Askdelete");
            this.Property(t => t.AskCause).HasColumnName("AskCause");
            this.Property(t => t.AskBack).HasColumnName("AskBack");
            this.Property(t => t.DownFromFescoDate).HasColumnName("DownFromFescoDate");
            this.Property(t => t.Isduty).HasColumnName("Isduty");
            this.Property(t => t.Dutyid).HasColumnName("Dutyid");
            this.Property(t => t.CardRule).HasColumnName("CardRule");
            this.Property(t => t.DealRule).HasColumnName("DealRule");
            this.Property(t => t.SpType).HasColumnName("SpType");
            this.Property(t => t.Ext1).HasColumnName("Ext1");
            this.Property(t => t.Ext2).HasColumnName("Ext2");
            this.Property(t => t.Ext3).HasColumnName("Ext3");
            this.Property(t => t.Ext4).HasColumnName("Ext4");
            this.Property(t => t.Ext5).HasColumnName("Ext5");
            this.Property(t => t.Ext6).HasColumnName("Ext6");
            this.Property(t => t.IsMonyOnly).HasColumnName("IsMonyOnly");
            this.Property(t => t.IsFree).HasColumnName("IsFree");
            this.Property(t => t.IsSendByGys).HasColumnName("IsSendByGys");
            this.Property(t => t.Buylimit).HasColumnName("Buylimit");
            this.Property(t => t.Lmtdate).HasColumnName("Lmtdate");
            this.Property(t => t.Hitstime).HasColumnName("Hitstime");
            this.Property(t => t.Hits).HasColumnName("Hits");
            this.Property(t => t.SoHuId).HasColumnName("SoHuId");
            this.Property(t => t.Belongto).HasColumnName("Belongto");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.RoleName).HasColumnName("RoleName");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperName).HasColumnName("OperName");
            this.Property(t => t.Calculation).HasColumnName("Calculation");
        }
    }
}
