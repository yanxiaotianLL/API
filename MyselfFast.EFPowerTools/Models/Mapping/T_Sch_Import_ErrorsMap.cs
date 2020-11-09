using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sch_Import_ErrorsMap : EntityTypeConfiguration<T_Sch_Import_Errors>
    {
        public T_Sch_Import_ErrorsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Usedname)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ErrorText)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_Sch_Import_Errors");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Planid).HasColumnName("Planid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Usedname).HasColumnName("Usedname");
            this.Property(t => t.ImportDate).HasColumnName("ImportDate");
            this.Property(t => t.ErrorText).HasColumnName("ErrorText");
        }
    }
}
