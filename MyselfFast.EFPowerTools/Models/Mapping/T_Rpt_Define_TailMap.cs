using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Rpt_Define_TailMap : EntityTypeConfiguration<T_Rpt_Define_Tail>
    {
        public T_Rpt_Define_TailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FieldName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RptTitle)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Rpt_Define_Tail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Rptid).HasColumnName("Rptid");
            this.Property(t => t.Idx).HasColumnName("Idx");
            this.Property(t => t.FieldName).HasColumnName("FieldName");
            this.Property(t => t.RptTitle).HasColumnName("RptTitle");
            this.Property(t => t.IsQry).HasColumnName("IsQry");
            this.Property(t => t.IsShow).HasColumnName("IsShow");
            this.Property(t => t.IsOut).HasColumnName("IsOut");
        }
    }
}
