using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_User_FenBakFesco_LogMap : EntityTypeConfiguration<T_Fes_User_FenBakFesco_Log>
    {
        public T_Fes_User_FenBakFesco_LogMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Fno)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.AuditBak)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Fes_User_FenBakFesco_Log");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Pcid).HasColumnName("Pcid");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fno).HasColumnName("Fno");
            this.Property(t => t.Fen).HasColumnName("Fen");
            this.Property(t => t.AuditBak).HasColumnName("AuditBak");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        }
    }
}
