using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class NewpriceMap : EntityTypeConfiguration<Newprice>
    {
        public NewpriceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Price });

            // Properties
            this.Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Price)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Newprice");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
