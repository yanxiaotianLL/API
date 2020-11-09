using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Imp_NewUser_NoteMap : EntityTypeConfiguration<T_Imp_NewUser_Note>
    {
        public T_Imp_NewUser_NoteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Pc)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CreaterName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Imp_NewUser_Note");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Pc).HasColumnName("Pc");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Instype).HasColumnName("Instype");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CreaterId).HasColumnName("CreaterId");
            this.Property(t => t.CreaterName).HasColumnName("CreaterName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        }
    }
}