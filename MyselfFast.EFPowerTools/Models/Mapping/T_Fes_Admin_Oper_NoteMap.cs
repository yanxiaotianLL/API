using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_Admin_Oper_NoteMap : EntityTypeConfiguration<T_Fes_Admin_Oper_Note>
    {
        public T_Fes_Admin_Oper_NoteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Opername)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Oper)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("T_Fes_Admin_Oper_Note");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Operkey).HasColumnName("Operkey");
            this.Property(t => t.Daykey).HasColumnName("Daykey");
            this.Property(t => t.Operid).HasColumnName("Operid");
            this.Property(t => t.Opername).HasColumnName("Opername");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperType).HasColumnName("OperType");
            this.Property(t => t.Oper).HasColumnName("Oper");
            this.Property(t => t.Memo).HasColumnName("Memo");
        }
    }
}
