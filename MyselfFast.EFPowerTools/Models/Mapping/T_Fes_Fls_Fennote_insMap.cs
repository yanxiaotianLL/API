using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_Fls_Fennote_insMap : EntityTypeConfiguration<T_Fes_Fls_Fennote_ins>
    {
        public T_Fes_Fls_Fennote_insMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Fno)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Pc)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CreaterName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.accessory)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("T_Fes_Fls_Fennote_ins");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fentype).HasColumnName("Fentype");
            this.Property(t => t.Fno).HasColumnName("Fno");
            this.Property(t => t.Pc).HasColumnName("Pc");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CreaterId).HasColumnName("CreaterId");
            this.Property(t => t.CreaterName).HasColumnName("CreaterName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.IsCommit).HasColumnName("IsCommit");
            this.Property(t => t.accessory).HasColumnName("accessory");
            this.Property(t => t.LmtEnd).HasColumnName("LmtEnd");
            this.Property(t => t.IsSame).HasColumnName("IsSame");
        }
    }
}
