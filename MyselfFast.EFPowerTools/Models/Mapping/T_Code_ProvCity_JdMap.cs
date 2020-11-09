using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Code_ProvCity_JdMap : EntityTypeConfiguration<T_Code_ProvCity_Jd>
    {
        public T_Code_ProvCity_JdMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Ename)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("T_Code_ProvCity_Jd");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Ename).HasColumnName("Ename");
            this.Property(t => t.Pid).HasColumnName("Pid");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.Show).HasColumnName("Show");
            this.Property(t => t.Grade).HasColumnName("Grade");
        }
    }
}
