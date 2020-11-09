using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.Collect.Core.Test.Models.Mapping
{
    public class T_JC_FileMap : EntityTypeConfiguration<T_JC_File>
    {
        public T_JC_FileMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FileID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FileName)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(50);

            this.Property(t => t.FileType)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_JC_File");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FileID).HasColumnName("FileID");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.FileType).HasColumnName("FileType");
            this.Property(t => t.TaskId).HasColumnName("TaskId");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");

            // Relationships
            this.HasOptional(t => t.T_JC_Task)
                .WithMany(t => t.T_JC_File)
                .HasForeignKey(d => d.TaskId);

        }
    }
}
