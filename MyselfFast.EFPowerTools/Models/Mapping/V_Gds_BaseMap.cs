using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_Gds_BaseMap : EntityTypeConfiguration<V_Gds_Base>
    {
        public V_Gds_BaseMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Gysid, t.GysJiancheng, t.Gysname, t.Numbers, t.Cname, t.Ename, t.AliasName, t.AliasEName, t.Stand, t.Model, t.Product, t.Ysname, t.Ysname2, t.Mcid, t.Mcname, t.Jianj, t.Tuiable, t.Attention, t.State, t.IsUsed, t.PubToFescoDate, t.DownFromGysDate, t.SelectByFescoDate, t.Askdelete, t.AskCause, t.AskBack, t.DownFromFescoDate, t.Isduty, t.Dutyid, t.CardRule, t.DealRule, t.SpType, t.Ext1, t.Ext2, t.Ext3, t.Ext4, t.Ext5, t.Ext6, t.IsMonyOnly, t.IsSendByGys, t.Lmtdate, t.Hitstime, t.Hits, t.SoHuId, t.Belongto, t.RoleID, t.RoleName, t.OperId, t.OperName });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Gysid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.Mcid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Mcname)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Jianj)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.Attention)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.State)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Askdelete)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AskCause)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.AskBack)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Dutyid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CardRule)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.DealRule)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SpType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.Hits)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SoHuId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Belongto)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoleName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("V_Gds_Base");
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
            this.Property(t => t.IsSendByGys).HasColumnName("IsSendByGys");
            this.Property(t => t.Lmtdate).HasColumnName("Lmtdate");
            this.Property(t => t.Hitstime).HasColumnName("Hitstime");
            this.Property(t => t.Hits).HasColumnName("Hits");
            this.Property(t => t.SoHuId).HasColumnName("SoHuId");
            this.Property(t => t.Belongto).HasColumnName("Belongto");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.RoleName).HasColumnName("RoleName");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperName).HasColumnName("OperName");
        }
    }
}
