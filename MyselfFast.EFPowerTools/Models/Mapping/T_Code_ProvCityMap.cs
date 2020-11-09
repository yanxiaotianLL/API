using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Code_ProvCityMap : EntityTypeConfiguration<T_Code_ProvCity>
    {
        public T_Code_ProvCityMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Cname, t.Ename, t.Pid, t.Area, t.Show, t.Jdid });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Ename)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Pid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Area)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Jdid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_Code_ProvCity");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Ename).HasColumnName("Ename");
            this.Property(t => t.Pid).HasColumnName("Pid");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.Show).HasColumnName("Show");
            this.Property(t => t.Jdid).HasColumnName("Jdid");
        }
    }
}
