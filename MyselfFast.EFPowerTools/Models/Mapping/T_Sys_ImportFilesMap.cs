using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sys_ImportFilesMap : EntityTypeConfiguration<T_Sys_ImportFiles>
    {
        public T_Sys_ImportFilesMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FileNameOld)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FileNameNew)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Path)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.Message)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ParaJson)
                .IsRequired()
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("T_Sys_ImportFiles");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.FileNameOld).HasColumnName("FileNameOld");
            this.Property(t => t.FileNameNew).HasColumnName("FileNameNew");
            this.Property(t => t.Path).HasColumnName("Path");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.ParaJson).HasColumnName("ParaJson");
        }
    }
}
