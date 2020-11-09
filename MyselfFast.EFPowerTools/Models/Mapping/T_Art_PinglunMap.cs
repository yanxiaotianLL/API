using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Art_PinglunMap : EntityTypeConfiguration<T_Art_Pinglun>
    {
        public T_Art_PinglunMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Quest)
                .IsRequired()
                .HasMaxLength(400);

            // Table & Column Mappings
            this.ToTable("T_Art_Pinglun");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Aid).HasColumnName("Aid");
            this.Property(t => t.Quest).HasColumnName("Quest");
            this.Property(t => t.Udate).HasColumnName("Udate");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
