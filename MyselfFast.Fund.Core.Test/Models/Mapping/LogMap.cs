using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.Collect.Core.Test.Models.Mapping
{
    public class LogMap : EntityTypeConfiguration<Log>
    {
        public LogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Date, t.Thread, t.Level, t.Logger, t.Message, t.Exception, t.SystemName, t.ModuleName, t.Name, t.Content, t.Code, t.Key1, t.Key2, t.Key3, t.Key4 });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Thread)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Level)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Logger)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Message)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.Exception)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.SystemName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ModuleName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Content)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Key1)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Key2)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Key3)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Key4)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Log");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Thread).HasColumnName("Thread");
            this.Property(t => t.Level).HasColumnName("Level");
            this.Property(t => t.Logger).HasColumnName("Logger");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.Exception).HasColumnName("Exception");
            this.Property(t => t.SystemName).HasColumnName("SystemName");
            this.Property(t => t.ModuleName).HasColumnName("ModuleName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Key1).HasColumnName("Key1");
            this.Property(t => t.Key2).HasColumnName("Key2");
            this.Property(t => t.Key3).HasColumnName("Key3");
            this.Property(t => t.Key4).HasColumnName("Key4");
        }
    }
}
