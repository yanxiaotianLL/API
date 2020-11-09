using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_User_Check_NoteMap : EntityTypeConfiguration<T_Fes_User_Check_Note>
    {
        public T_Fes_User_Check_NoteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Checkname)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Fes_User_Check_Note");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Checktype).HasColumnName("Checktype");
            this.Property(t => t.Checkname).HasColumnName("Checkname");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.Gendate).HasColumnName("Gendate");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
