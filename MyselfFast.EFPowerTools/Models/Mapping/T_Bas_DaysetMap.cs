using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Bas_DaysetMap : EntityTypeConfiguration<T_Bas_Dayset>
    {
        public T_Bas_DaysetMap()
        {
            // Primary Key
            this.HasKey(t => t.Sdate);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.DayScript)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Bas_Dayset");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Sdate).HasColumnName("Sdate");
            this.Property(t => t.Wday).HasColumnName("Wday");
            this.Property(t => t.Idx).HasColumnName("Idx");
            this.Property(t => t.DayScript).HasColumnName("DayScript");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
        }
    }
}
