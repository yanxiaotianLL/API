using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_ActualMap : EntityTypeConfiguration<Hth_T_Actual>
    {
        public Hth_T_ActualMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.OrderIds)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SendCom)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SendNO)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Phone)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.TAdress)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.TCom)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TNO)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TPhone)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.Tname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FAdress)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.FCom)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FNO)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FPhone)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.Fname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CreateSign)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Hth_T_Actual");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OrderIds).HasColumnName("OrderIds");
            this.Property(t => t.AType).HasColumnName("AType");
            this.Property(t => t.SendCom).HasColumnName("SendCom");
            this.Property(t => t.SendNO).HasColumnName("SendNO");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.TType).HasColumnName("TType");
            this.Property(t => t.TPosition).HasColumnName("TPosition");
            this.Property(t => t.TAdress).HasColumnName("TAdress");
            this.Property(t => t.TCom).HasColumnName("TCom");
            this.Property(t => t.TNO).HasColumnName("TNO");
            this.Property(t => t.TPhone).HasColumnName("TPhone");
            this.Property(t => t.Tname).HasColumnName("Tname");
            this.Property(t => t.TCode).HasColumnName("TCode");
            this.Property(t => t.Fen).HasColumnName("Fen");
            this.Property(t => t.FType).HasColumnName("FType");
            this.Property(t => t.FPosition).HasColumnName("FPosition");
            this.Property(t => t.FAdress).HasColumnName("FAdress");
            this.Property(t => t.FCom).HasColumnName("FCom");
            this.Property(t => t.FNO).HasColumnName("FNO");
            this.Property(t => t.FPhone).HasColumnName("FPhone");
            this.Property(t => t.Fname).HasColumnName("Fname");
            this.Property(t => t.FCode).HasColumnName("FCode");
            this.Property(t => t.CreateSign).HasColumnName("CreateSign");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.IsSend).HasColumnName("IsSend");
            this.Property(t => t.OrderWrapID).HasColumnName("OrderWrapID");
        }
    }
}
