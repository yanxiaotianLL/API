using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_Gds_ColTailMap : EntityTypeConfiguration<V_Gds_ColTail>
    {
        public V_Gds_ColTailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.PlanId, t.Idx, t.Cid, t.Hid, t.Selectbyfescodate, t.Gysid, t.GysJiancheng, t.Gysname, t.IsSendByGys, t.Numbers, t.Cname, t.Ename, t.AliasName, t.AliasEName, t.Stand, t.Model, t.Product, t.Ysname, t.Ysname2, t.Mcid, t.Mcname, t.Tuiable, t.Attention, t.State, t.Hits, t.Hitstime, t.Img, t.Imgs, t.Ys1, t.Ys1name, t.Ys2, t.Ys2name, t.Price, t.Kucun, t.IsDefault, t.FenType, t.FenTypeName, t.FenStans, t.Spread, t.Fenable, t.Hiskucun });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PlanId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Idx)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Cid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Hid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.Attention)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.State)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Hits)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Img)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Imgs)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.Ys1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ys1name)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Ys2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ys2name)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Price)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Kucun)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FenType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FenTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FenStans)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Hiskucun)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("V_Gds_ColTail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PlanId).HasColumnName("PlanId");
            this.Property(t => t.Idx).HasColumnName("Idx");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Hid).HasColumnName("Hid");
            this.Property(t => t.Selectbyfescodate).HasColumnName("Selectbyfescodate");
            this.Property(t => t.Gysid).HasColumnName("Gysid");
            this.Property(t => t.GysJiancheng).HasColumnName("GysJiancheng");
            this.Property(t => t.Gysname).HasColumnName("Gysname");
            this.Property(t => t.IsSendByGys).HasColumnName("IsSendByGys");
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
            this.Property(t => t.Tuiable).HasColumnName("Tuiable");
            this.Property(t => t.Attention).HasColumnName("Attention");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Hits).HasColumnName("Hits");
            this.Property(t => t.Hitstime).HasColumnName("Hitstime");
            this.Property(t => t.Img).HasColumnName("Img");
            this.Property(t => t.Imgs).HasColumnName("Imgs");
            this.Property(t => t.Ys1).HasColumnName("Ys1");
            this.Property(t => t.Ys1name).HasColumnName("Ys1name");
            this.Property(t => t.Ys2).HasColumnName("Ys2");
            this.Property(t => t.Ys2name).HasColumnName("Ys2name");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Kucun).HasColumnName("Kucun");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");
            this.Property(t => t.FenType).HasColumnName("FenType");
            this.Property(t => t.FenTypeName).HasColumnName("FenTypeName");
            this.Property(t => t.FenStans).HasColumnName("FenStans");
            this.Property(t => t.Spread).HasColumnName("Spread");
            this.Property(t => t.Fenable).HasColumnName("Fenable");
            this.Property(t => t.Hiskucun).HasColumnName("Hiskucun");
        }
    }
}
