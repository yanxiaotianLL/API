using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sch_PlanMap : EntityTypeConfiguration<T_Sch_Plan>
    {
        public T_Sch_PlanMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Orderby)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.PlanName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.JianJie)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.ReceptPage)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.FenTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FenStans)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Description)
                .IsRequired();

            this.Property(t => t.PageType)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.RoleName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.OperName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Img)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ExtName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.WxIcon)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.PcImg)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Sch_Plan");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Grd).HasColumnName("Grd");
            this.Property(t => t.Orderby).HasColumnName("Orderby");
            this.Property(t => t.Parentid).HasColumnName("Parentid");
            this.Property(t => t.PlanName).HasColumnName("PlanName");
            this.Property(t => t.JianJie).HasColumnName("JianJie");
            this.Property(t => t.ReceptPage).HasColumnName("ReceptPage");
            this.Property(t => t.FenType).HasColumnName("FenType");
            this.Property(t => t.FenTypeName).HasColumnName("FenTypeName");
            this.Property(t => t.FenStans).HasColumnName("FenStans");
            this.Property(t => t.Spread).HasColumnName("Spread");
            this.Property(t => t.Fenable).HasColumnName("Fenable");
            this.Property(t => t.ProductCategory).HasColumnName("ProductCategory");
            this.Property(t => t.PlanAttribute).HasColumnName("PlanAttribute");
            this.Property(t => t.ActivateSort).HasColumnName("ActivateSort");
            this.Property(t => t.Activatedate).HasColumnName("Activatedate");
            this.Property(t => t.ActivedBefore).HasColumnName("ActivedBefore");
            this.Property(t => t.ActivedAfter).HasColumnName("ActivedAfter");
            this.Property(t => t.EffectiveDate).HasColumnName("EffectiveDate");
            this.Property(t => t.DeadlineDate).HasColumnName("DeadlineDate");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.PageType).HasColumnName("PageType");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Belongto).HasColumnName("Belongto");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.RoleName).HasColumnName("RoleName");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperName).HasColumnName("OperName");
            this.Property(t => t.Edittime).HasColumnName("Edittime");
            this.Property(t => t.Minsels).HasColumnName("Minsels");
            this.Property(t => t.Maxsels).HasColumnName("Maxsels");
            this.Property(t => t.SelLimit).HasColumnName("SelLimit");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.Repeatable).HasColumnName("Repeatable");
            this.Property(t => t.ShareFrom).HasColumnName("ShareFrom");
            this.Property(t => t.IsForShared).HasColumnName("IsForShared");
            this.Property(t => t.ShowInList).HasColumnName("ShowInList");
            this.Property(t => t.Img).HasColumnName("Img");
            this.Property(t => t.PlanArea).HasColumnName("PlanArea");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.NeedExt).HasColumnName("NeedExt");
            this.Property(t => t.IsOnlyWorking).HasColumnName("IsOnlyWorking");
            this.Property(t => t.ExtName).HasColumnName("ExtName");
            this.Property(t => t.IsLeaf).HasColumnName("IsLeaf");
            this.Property(t => t.ExtFenAble).HasColumnName("ExtFenAble");
            this.Property(t => t.PriceShowType).HasColumnName("PriceShowType");
            this.Property(t => t.WxIcon).HasColumnName("WxIcon");
            this.Property(t => t.PcImg).HasColumnName("PcImg");
            this.Property(t => t.IsNeedDocking).HasColumnName("IsNeedDocking");
        }
    }
}
