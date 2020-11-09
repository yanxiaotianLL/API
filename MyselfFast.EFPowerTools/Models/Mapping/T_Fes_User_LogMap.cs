using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_User_LogMap : EntityTypeConfiguration<T_Fes_User_Log>
    {
        public T_Fes_User_LogMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Opername)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Beizu)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Fes_User_Log");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Opertime).HasColumnName("Opertime");
            this.Property(t => t.Opertype).HasColumnName("Opertype");
            this.Property(t => t.Opername).HasColumnName("Opername");
            this.Property(t => t.Beizu).HasColumnName("Beizu");
        }
    }
}
