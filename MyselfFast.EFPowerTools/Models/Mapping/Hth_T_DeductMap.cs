using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_DeductMap : EntityTypeConfiguration<Hth_T_Deduct>
    {
        public Hth_T_DeductMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Note)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DrugName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Hth_T_Deduct");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DType).HasColumnName("DType");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Drug).HasColumnName("Drug");
            this.Property(t => t.ImgId).HasColumnName("ImgId");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Proportion).HasColumnName("Proportion");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.DrugName).HasColumnName("DrugName");
        }
    }
}
