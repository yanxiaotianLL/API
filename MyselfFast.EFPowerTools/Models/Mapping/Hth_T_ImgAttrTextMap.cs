using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_ImgAttrTextMap : EntityTypeConfiguration<Hth_T_ImgAttrText>
    {
        public Hth_T_ImgAttrTextMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Content)
                .IsRequired()
                .HasMaxLength(550);

            // Table & Column Mappings
            this.ToTable("Hth_T_ImgAttrText");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ImgId).HasColumnName("ImgId");
            this.Property(t => t.AttrId).HasColumnName("AttrId");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
