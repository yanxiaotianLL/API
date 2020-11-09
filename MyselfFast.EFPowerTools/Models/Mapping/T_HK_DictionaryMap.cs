using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_HK_DictionaryMap : EntityTypeConfiguration<T_HK_Dictionary>
    {
        public T_HK_DictionaryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DictValue)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.DictName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.KeyValue)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.keyDesc)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_HK_Dictionary");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.DictValue).HasColumnName("DictValue");
            this.Property(t => t.DictName).HasColumnName("DictName");
            this.Property(t => t.KeyValue).HasColumnName("KeyValue");
            this.Property(t => t.keyDesc).HasColumnName("keyDesc");
            this.Property(t => t.Flag).HasColumnName("Flag");
            this.Property(t => t.OrderNum).HasColumnName("OrderNum");
        }
    }
}
