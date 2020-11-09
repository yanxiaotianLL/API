using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_User_Frostfen_insMap : EntityTypeConfiguration<T_Fes_User_Frostfen_ins>
    {
        public T_Fes_User_Frostfen_insMap()
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

            this.Property(t => t.UpdateName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Bak)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Fes_User_Frostfen_ins");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fentype).HasColumnName("Fentype");
            this.Property(t => t.Fno).HasColumnName("Fno");
            this.Property(t => t.Pc).HasColumnName("Pc");
            this.Property(t => t.Optype).HasColumnName("Optype");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CreaterId).HasColumnName("CreaterId");
            this.Property(t => t.CreaterName).HasColumnName("CreaterName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.IsCommit).HasColumnName("IsCommit");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.UpdateName).HasColumnName("UpdateName");
            this.Property(t => t.Bak).HasColumnName("Bak");
        }
    }
}
