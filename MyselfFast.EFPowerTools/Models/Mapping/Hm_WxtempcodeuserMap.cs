using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hm_WxtempcodeuserMap : EntityTypeConfiguration<Hm_Wxtempcodeuser>
    {
        public Hm_WxtempcodeuserMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Uid });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Uid)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Hm_Wxtempcodeuser");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Uid).HasColumnName("Uid");
        }
    }
}
