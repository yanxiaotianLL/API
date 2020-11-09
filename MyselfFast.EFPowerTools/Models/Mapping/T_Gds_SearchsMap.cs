using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_SearchsMap : EntityTypeConfiguration<T_Gds_Searchs>
    {
        public T_Gds_SearchsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Findstr)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("T_Gds_Searchs");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Findstr).HasColumnName("Findstr");
            this.Property(t => t.Hits).HasColumnName("Hits");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
        }
    }
}
