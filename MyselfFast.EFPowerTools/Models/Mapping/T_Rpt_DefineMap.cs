using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Rpt_DefineMap : EntityTypeConfiguration<T_Rpt_Define>
    {
        public T_Rpt_DefineMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.LinkTable)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.LinkProc)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Rpt_Define");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.LinkTable).HasColumnName("LinkTable");
            this.Property(t => t.LinkProc).HasColumnName("LinkProc");
            this.Property(t => t.GenType).HasColumnName("GenType");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.RolType).HasColumnName("RolType");
            this.Property(t => t.OperType).HasColumnName("OperType");
        }
    }
}
