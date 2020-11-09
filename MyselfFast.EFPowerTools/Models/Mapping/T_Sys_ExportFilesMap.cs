using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sys_ExportFilesMap : EntityTypeConfiguration<T_Sys_ExportFiles>
    {
        public T_Sys_ExportFilesMap()
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

            this.Property(t => t.Path)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.Message)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ParmsJson)
                .IsRequired();

            this.Property(t => t.FileName)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Sys_ExportFiles");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Path).HasColumnName("Path");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.ParmsJson).HasColumnName("ParmsJson");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.OutsTime).HasColumnName("OutsTime");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.FileName).HasColumnName("FileName");
        }
    }
}
