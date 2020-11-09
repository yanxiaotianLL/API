using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_ExImportFilesMap : EntityTypeConfiguration<T_ExImportFiles>
    {
        public T_ExImportFilesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Type, t.TypeName, t.UserId, t.UserName, t.State, t.FileNameOld, t.FileNameNew, t.Path, t.PramsJson, t.Message, t.CreateDate });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TypeName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.State)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FileNameOld)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FileNameNew)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Path)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PramsJson)
                .IsRequired()
                .HasMaxLength(8000);

            this.Property(t => t.Message)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("T_ExImportFiles");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.FileNameOld).HasColumnName("FileNameOld");
            this.Property(t => t.FileNameNew).HasColumnName("FileNameNew");
            this.Property(t => t.Path).HasColumnName("Path");
            this.Property(t => t.PramsJson).HasColumnName("PramsJson");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
        }
    }
}
