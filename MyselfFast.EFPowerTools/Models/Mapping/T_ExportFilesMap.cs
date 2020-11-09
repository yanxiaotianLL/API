using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_ExportFilesMap : EntityTypeConfiguration<T_ExportFiles>
    {
        public T_ExportFilesMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.TypeName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Path)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Message)
                .IsRequired();

            this.Property(t => t.PramsJson)
                .IsRequired()
                .HasMaxLength(8000);

            // Table & Column Mappings
            this.ToTable("T_ExportFiles");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.Userid).HasColumnName("Userid");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Path).HasColumnName("Path");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.PramsJson).HasColumnName("PramsJson");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.OutsTime).HasColumnName("OutsTime");
            this.Property(t => t.RenId).HasColumnName("RenId");
        }
    }
}
