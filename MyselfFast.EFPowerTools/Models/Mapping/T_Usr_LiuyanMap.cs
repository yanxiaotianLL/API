using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Usr_LiuyanMap : EntityTypeConfiguration<T_Usr_Liuyan>
    {
        public T_Usr_LiuyanMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Uid)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Quest)
                .IsRequired()
                .HasMaxLength(800);

            this.Property(t => t.Asks)
                .IsRequired()
                .HasMaxLength(800);

            // Table & Column Mappings
            this.ToTable("T_Usr_Liuyan");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Uid).HasColumnName("Uid");
            this.Property(t => t.Quest).HasColumnName("Quest");
            this.Property(t => t.Udate).HasColumnName("Udate");
            this.Property(t => t.Asks).HasColumnName("Asks");
            this.Property(t => t.Ddate).HasColumnName("Ddate");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
