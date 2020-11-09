using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_User_CardnoteMap : EntityTypeConfiguration<T_Fes_User_Cardnote>
    {
        public T_Fes_User_CardnoteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Cardnum)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FenStans)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Cause)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Bak)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Oper)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Fes_User_Cardnote");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Cardnum).HasColumnName("Cardnum");
            this.Property(t => t.Aid).HasColumnName("Aid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.FenTag).HasColumnName("FenTag");
            this.Property(t => t.Fen).HasColumnName("Fen");
            this.Property(t => t.FenStans).HasColumnName("FenStans");
            this.Property(t => t.Causeid).HasColumnName("Causeid");
            this.Property(t => t.Cause).HasColumnName("Cause");
            this.Property(t => t.Bak).HasColumnName("Bak");
            this.Property(t => t.Gendate).HasColumnName("Gendate");
            this.Property(t => t.Fstate).HasColumnName("Fstate");
            this.Property(t => t.Operid).HasColumnName("Operid");
            this.Property(t => t.Oper).HasColumnName("Oper");
            this.Property(t => t.Opertime).HasColumnName("Opertime");
            this.Property(t => t.IsCommit).HasColumnName("IsCommit");
        }
    }
}
