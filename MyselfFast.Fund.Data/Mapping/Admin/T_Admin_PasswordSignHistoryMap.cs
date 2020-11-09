using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using myselfFast.Fund.Core.Domain.Admin;

namespace myselfFast.Fund.Data.Mapping.Admin
{
    public class T_Admin_PasswordSignHistoryMap : myselfFastEntityTypeConfiguration<T_Admin_PasswordSignHistory>
    {
        public T_Admin_PasswordSignHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Sign)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(30);

            this.Property(t => t.UserName)
                .HasMaxLength(30);

            this.Property(t => t.Url)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("T_Admin_PasswordSignHistory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateAdmin).HasColumnName("CreateAdmin");
            this.Property(t => t.Sign).HasColumnName("Sign");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.AdminUserId).HasColumnName("AdminUserId");
        }
    }
}

