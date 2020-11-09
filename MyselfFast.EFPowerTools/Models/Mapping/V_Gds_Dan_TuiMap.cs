using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_Gds_Dan_TuiMap : EntityTypeConfiguration<V_Gds_Dan_Tui>
    {
        public V_Gds_Dan_TuiMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Fid, t.Fesid, t.Orderid, t.OrderNo, t.Mny, t.GenDate, t.State, t.Planid, t.Hno, t.Cname, t.Ename, t.Usedname, t.Gno, t.CardId, t.Mobile });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fesid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Orderid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrderNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mny)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.State)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Planid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Hno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Ename)
                .IsRequired()
                .HasMaxLength(800);

            this.Property(t => t.Usedname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Gno)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CardId)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("V_Gds_Dan_Tui");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Orderid).HasColumnName("Orderid");
            this.Property(t => t.OrderNo).HasColumnName("OrderNo");
            this.Property(t => t.Mny).HasColumnName("Mny");
            this.Property(t => t.GenDate).HasColumnName("GenDate");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Planid).HasColumnName("Planid");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Ename).HasColumnName("Ename");
            this.Property(t => t.Usedname).HasColumnName("Usedname");
            this.Property(t => t.Gno).HasColumnName("Gno");
            this.Property(t => t.CardId).HasColumnName("CardId");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
        }
    }
}
