using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.Collect.Core.Test.Models.Mapping
{
    public class T_Admin_AccountMap : EntityTypeConfiguration<T_Admin_Account>
    {
        public T_Admin_AccountMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RealName)
                .HasMaxLength(10);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.Telephone)
                .HasMaxLength(20);

            this.Property(t => t.DepartName)
                .HasMaxLength(50);

            this.Property(t => t.CreateAdmin)
                .HasMaxLength(20);

            this.Property(t => t.UpdateAdmin)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("T_Admin_Account");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.DepartID).HasColumnName("DepartID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.RealName).HasColumnName("RealName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Telephone).HasColumnName("Telephone");
            this.Property(t => t.DepartName).HasColumnName("DepartName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateAdmin).HasColumnName("CreateAdmin");
            this.Property(t => t.UpdateAdmin).HasColumnName("UpdateAdmin");

            // Relationships
            this.HasRequired(t => t.T_Admin_Depart)
                .WithMany(t => t.T_Admin_Account)
                .HasForeignKey(d => d.DepartID);

        }
    }
}
