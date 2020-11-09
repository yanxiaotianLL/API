using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_GJJZQ_AccessoryMap : EntityTypeConfiguration<T_GJJZQ_Accessory>
    {
        public T_GJJZQ_AccessoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.TitleNo, t.Answer, t.Sort });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TitleNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Answer)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.Accessory)
                .HasMaxLength(100);

            this.Property(t => t.Sort)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_GJJZQ_Accessory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TitleNo).HasColumnName("TitleNo");
            this.Property(t => t.Answer).HasColumnName("Answer");
            this.Property(t => t.Accessory).HasColumnName("Accessory");
            this.Property(t => t.Sort).HasColumnName("Sort");
        }
    }
}
