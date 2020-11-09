using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_Dan_Interface_NoteMap : EntityTypeConfiguration<T_Gds_Dan_Interface_Note>
    {
        public T_Gds_Dan_Interface_NoteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Prams)
                .IsRequired()
                .HasMaxLength(8000);

            // Table & Column Mappings
            this.ToTable("T_Gds_Dan_Interface_Note");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.InterType).HasColumnName("InterType");
            this.Property(t => t.piCallRecId).HasColumnName("piCallRecId");
            this.Property(t => t.Prams).HasColumnName("Prams");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Gendate).HasColumnName("Gendate");
        }
    }
}
