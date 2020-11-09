using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sys_MailsMap : EntityTypeConfiguration<T_Sys_Mails>
    {
        public T_Sys_MailsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Sour, t.Fesid, t.SourId, t.Email, t.Subject, t.Subtext, t.PreSendTime, t.LastSendTime, t.Times, t.State, t.CreaterId, t.CreaterName, t.CreateTime });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Sour)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Fesid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SourId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Subject)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Subtext)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.Times)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.State)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CreaterId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CreaterName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Sys_Mails");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Sour).HasColumnName("Sour");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.SourId).HasColumnName("SourId");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Subject).HasColumnName("Subject");
            this.Property(t => t.Subtext).HasColumnName("Subtext");
            this.Property(t => t.PreSendTime).HasColumnName("PreSendTime");
            this.Property(t => t.LastSendTime).HasColumnName("LastSendTime");
            this.Property(t => t.Times).HasColumnName("Times");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CreaterId).HasColumnName("CreaterId");
            this.Property(t => t.CreaterName).HasColumnName("CreaterName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        }
    }
}
