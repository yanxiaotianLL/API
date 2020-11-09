using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_Pinglun_BackMap : EntityTypeConfiguration<T_Gds_Pinglun_Back>
    {
        public T_Gds_Pinglun_BackMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.OperName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Asks)
                .IsRequired()
                .HasMaxLength(800);

            // Table & Column Mappings
            this.ToTable("T_Gds_Pinglun_Back");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Pid).HasColumnName("Pid");
            this.Property(t => t.Operid).HasColumnName("Operid");
            this.Property(t => t.OperName).HasColumnName("OperName");
            this.Property(t => t.Asks).HasColumnName("Asks");
            this.Property(t => t.Backdate).HasColumnName("Backdate");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
