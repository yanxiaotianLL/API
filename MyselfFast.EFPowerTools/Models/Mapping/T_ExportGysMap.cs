using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_ExportGysMap : EntityTypeConfiguration<T_ExportGys>
    {
        public T_ExportGysMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Type, t.TypeName, t.Userid, t.UserName, t.Path, t.State, t.Message, t.PramsJson, t.CreateDate, t.OutsTime });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TypeName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Userid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Path)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.State)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Message)
                .IsRequired();

            this.Property(t => t.PramsJson)
                .IsRequired()
                .HasMaxLength(8000);

            // Table & Column Mappings
            this.ToTable("T_ExportGys");
            this.Property(t => t.Id).HasColumnName("Id");
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
        }
    }
}
