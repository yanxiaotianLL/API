using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_User_Leave_NoteMap : EntityTypeConfiguration<T_Fes_User_Leave_Note>
    {
        public T_Fes_User_Leave_NoteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.OperName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_Fes_User_Leave_Note");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.OperType).HasColumnName("OperType");
            this.Property(t => t.OperDate).HasColumnName("OperDate");
            this.Property(t => t.Operid).HasColumnName("Operid");
            this.Property(t => t.OperName).HasColumnName("OperName");
        }
    }
}
