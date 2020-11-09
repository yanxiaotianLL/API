using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Rpt_Gen_NoteMap : EntityTypeConfiguration<T_Rpt_Gen_Note>
    {
        public T_Rpt_Gen_NoteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Rpt_Gen_Note");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Rptid).HasColumnName("Rptid");
            this.Property(t => t.Cyear).HasColumnName("Cyear");
            this.Property(t => t.Cmonth).HasColumnName("Cmonth");
            this.Property(t => t.Cday).HasColumnName("Cday");
            this.Property(t => t.Gendate).HasColumnName("Gendate");
        }
    }
}
