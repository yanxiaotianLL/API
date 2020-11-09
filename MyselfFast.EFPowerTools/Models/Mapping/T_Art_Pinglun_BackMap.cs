using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Art_Pinglun_BackMap : EntityTypeConfiguration<T_Art_Pinglun_Back>
    {
        public T_Art_Pinglun_BackMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Pid, t.Operid, t.Oper, t.Backs, t.Operdate, t.State });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Pid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Operid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Oper)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Backs)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.State)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_Art_Pinglun_Back");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Pid).HasColumnName("Pid");
            this.Property(t => t.Operid).HasColumnName("Operid");
            this.Property(t => t.Oper).HasColumnName("Oper");
            this.Property(t => t.Backs).HasColumnName("Backs");
            this.Property(t => t.Operdate).HasColumnName("Operdate");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
