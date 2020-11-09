using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_TrademarkMap : EntityTypeConfiguration<T_Gds_Trademark>
    {
        public T_Gds_TrademarkMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Tname)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Ename)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Script)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Img)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Links)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Frontimg)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Oper)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_Gds_Trademark");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Parentid).HasColumnName("Parentid");
            this.Property(t => t.Tid).HasColumnName("Tid");
            this.Property(t => t.Grd).HasColumnName("Grd");
            this.Property(t => t.Tname).HasColumnName("Tname");
            this.Property(t => t.Ename).HasColumnName("Ename");
            this.Property(t => t.Script).HasColumnName("Script");
            this.Property(t => t.Img).HasColumnName("Img");
            this.Property(t => t.Idx).HasColumnName("Idx");
            this.Property(t => t.Isdbl).HasColumnName("Isdbl");
            this.Property(t => t.Links).HasColumnName("Links");
            this.Property(t => t.Showtype).HasColumnName("Showtype");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Ctype).HasColumnName("Ctype");
            this.Property(t => t.Frontimg).HasColumnName("Frontimg");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.Oper).HasColumnName("Oper");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.IsWxShow).HasColumnName("IsWxShow");
        }
    }
}
