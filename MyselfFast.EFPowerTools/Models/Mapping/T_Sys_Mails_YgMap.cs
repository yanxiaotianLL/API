using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sys_Mails_YgMap : EntityTypeConfiguration<T_Sys_Mails_Yg>
    {
        public T_Sys_Mails_YgMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Context)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.Recontext)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.Aid)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("T_Sys_Mails_Yg");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Context).HasColumnName("Context");
            this.Property(t => t.Gendate).HasColumnName("Gendate");
            this.Property(t => t.Readstate).HasColumnName("Readstate");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Recontext).HasColumnName("Recontext");
            this.Property(t => t.Aid).HasColumnName("Aid");
            this.Property(t => t.Redate).HasColumnName("Redate");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
        }
    }
}
