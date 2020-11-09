using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_OrderImgMap : EntityTypeConfiguration<Hth_T_OrderImg>
    {
        public Hth_T_OrderImgMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Img)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.ImgNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Note)
                .IsRequired()
                .HasMaxLength(350);

            this.Property(t => t.ImgAddress)
                .HasMaxLength(200);

            this.Property(t => t.ImgUrl)
                .HasMaxLength(1000);

            this.Property(t => t.RealName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Hth_T_OrderImg");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.Img).HasColumnName("Img");
            this.Property(t => t.ImgNo).HasColumnName("ImgNo");
            this.Property(t => t.ImgSort).HasColumnName("ImgSort");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.SAmount).HasColumnName("SAmount");
            this.Property(t => t.YAmount).HasColumnName("YAmount");
            this.Property(t => t.BAmount).HasColumnName("BAmount");
            this.Property(t => t.HAmount).HasColumnName("HAmount");
            this.Property(t => t.RAmount).HasColumnName("RAmount");
            this.Property(t => t.ImgAddress).HasColumnName("ImgAddress");
            this.Property(t => t.ImgUrl).HasColumnName("ImgUrl");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.Settlement).HasColumnName("Settlement");
            this.Property(t => t.RealName).HasColumnName("RealName");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.IsPs).HasColumnName("IsPs");
        }
    }
}
