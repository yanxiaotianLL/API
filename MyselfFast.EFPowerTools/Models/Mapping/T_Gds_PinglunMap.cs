using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_PinglunMap : EntityTypeConfiguration<T_Gds_Pinglun>
    {
        public T_Gds_PinglunMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Quest)
                .IsRequired()
                .HasMaxLength(800);

            this.Property(t => t.Hname)
                .IsRequired()
                .HasMaxLength(160);

            // Table & Column Mappings
            this.ToTable("T_Gds_Pinglun");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Hid).HasColumnName("Hid");
            this.Property(t => t.Quest).HasColumnName("Quest");
            this.Property(t => t.Udate).HasColumnName("Udate");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Hname).HasColumnName("Hname");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
        }
    }
}
