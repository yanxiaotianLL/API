using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_OneCardIns_BaseMap : EntityTypeConfiguration<T_Fes_OneCardIns_Base>
    {
        public T_Fes_OneCardIns_BaseMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CardNum, t.PC });

            // Properties
            this.Property(t => t.CardNum)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CardPass)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Cid)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.CName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Borth)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PointDay)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.SendType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PC)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("T_Fes_OneCardIns_Base");
            this.Property(t => t.CardNum).HasColumnName("CardNum");
            this.Property(t => t.CardPass).HasColumnName("CardPass");
            this.Property(t => t.ServId).HasColumnName("ServId");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.CName).HasColumnName("CName");
            this.Property(t => t.Borth).HasColumnName("Borth");
            this.Property(t => t.PreDay).HasColumnName("PreDay");
            this.Property(t => t.PointDay).HasColumnName("PointDay");
            this.Property(t => t.FName).HasColumnName("FName");
            this.Property(t => t.SendType).HasColumnName("SendType");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.PC).HasColumnName("PC");
        }
    }
}
