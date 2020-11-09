using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_MicrAct_FilesMap : EntityTypeConfiguration<T_MicrAct_Files>
    {
        public T_MicrAct_FilesMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.OriginalFileName)
                .HasMaxLength(100);

            this.Property(t => t.FileName)
                .HasMaxLength(100);

            this.Property(t => t.FileSize)
                .HasMaxLength(20);

            this.Property(t => t.FilePath)
                .HasMaxLength(200);

            this.Property(t => t.PositonMark)
                .HasMaxLength(50);

            this.Property(t => t.CreateUser)
                .HasMaxLength(50);

            this.Property(t => t.UpdateUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_MicrAct_Files");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ActiveID).HasColumnName("ActiveID");
            this.Property(t => t.OriginalFileName).HasColumnName("OriginalFileName");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.FileSize).HasColumnName("FileSize");
            this.Property(t => t.FilePath).HasColumnName("FilePath");
            this.Property(t => t.FileType).HasColumnName("FileType");
            this.Property(t => t.PositonMark).HasColumnName("PositonMark");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.UpdateUser).HasColumnName("UpdateUser");
        }
    }
}
