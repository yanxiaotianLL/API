using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.Collect.Core.Test.Models.Mapping
{
    public class ApiInputLogMap : EntityTypeConfiguration<ApiInputLog>
    {
        public ApiInputLogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Date, t.Thread, t.Level, t.Logger, t.Message, t.Exception, t.Region, t.Controller, t.Action, t.AccountType, t.AccountName, t.HttpMethod, t.Sign, t.OriginalString, t.Ip, t.RequestTime, t.RequestContent, t.ResponseContent, t.Expire });

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

            this.Property(t => t.Region)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Controller)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Action)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AccountType)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.AccountName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HttpMethod)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.Sign)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OriginalString)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Ip)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.RequestContent)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.ResponseContent)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.Expire)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ApiInputLog");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Thread).HasColumnName("Thread");
            this.Property(t => t.Level).HasColumnName("Level");
            this.Property(t => t.Logger).HasColumnName("Logger");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.Exception).HasColumnName("Exception");
            this.Property(t => t.Region).HasColumnName("Region");
            this.Property(t => t.Controller).HasColumnName("Controller");
            this.Property(t => t.Action).HasColumnName("Action");
            this.Property(t => t.AccountType).HasColumnName("AccountType");
            this.Property(t => t.AccountName).HasColumnName("AccountName");
            this.Property(t => t.HttpMethod).HasColumnName("HttpMethod");
            this.Property(t => t.Sign).HasColumnName("Sign");
            this.Property(t => t.OriginalString).HasColumnName("OriginalString");
            this.Property(t => t.Ip).HasColumnName("Ip");
            this.Property(t => t.RequestTime).HasColumnName("RequestTime");
            this.Property(t => t.RequestContent).HasColumnName("RequestContent");
            this.Property(t => t.ResponseContent).HasColumnName("ResponseContent");
            this.Property(t => t.Expire).HasColumnName("Expire");
        }
    }
}
