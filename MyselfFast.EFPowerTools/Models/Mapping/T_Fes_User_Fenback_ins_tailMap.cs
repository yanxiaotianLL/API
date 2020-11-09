using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_User_Fenback_ins_tailMap : EntityTypeConfiguration<T_Fes_User_Fenback_ins_tail>
    {
        public T_Fes_User_Fenback_ins_tailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Fno)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Optype)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Opcause)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Bak)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.OperName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_Fes_User_Fenback_ins_tail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.FenType).HasColumnName("FenType");
            this.Property(t => t.Fno).HasColumnName("Fno");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.PcId).HasColumnName("PcId");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Fen).HasColumnName("Fen");
            this.Property(t => t.Optype).HasColumnName("Optype");
            this.Property(t => t.Opcause).HasColumnName("Opcause");
            this.Property(t => t.Bak).HasColumnName("Bak");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperName).HasColumnName("OperName");
            this.Property(t => t.ImportTime).HasColumnName("ImportTime");
        }
    }
}
