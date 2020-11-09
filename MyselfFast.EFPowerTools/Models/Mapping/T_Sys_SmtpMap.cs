using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sys_SmtpMap : EntityTypeConfiguration<T_Sys_Smtp>
    {
        public T_Sys_SmtpMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Email, t.Uid, t.Pwd, t.Fip });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Uid)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Pwd)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Fip)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("T_Sys_Smtp");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Uid).HasColumnName("Uid");
            this.Property(t => t.Pwd).HasColumnName("Pwd");
            this.Property(t => t.Fip).HasColumnName("Fip");
        }
    }
}
