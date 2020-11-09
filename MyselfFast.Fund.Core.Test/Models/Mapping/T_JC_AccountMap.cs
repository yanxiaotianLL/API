using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.Collect.Core.Test.Models.Mapping
{
    public class T_JC_AccountMap : EntityTypeConfiguration<T_JC_Account>
    {
        public T_JC_AccountMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CON_ACCE_ID)
                .HasMaxLength(20);

            this.Property(t => t.BUSI_CUST_NO)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Address_ID)
                .HasMaxLength(30);

            this.Property(t => t.Address)
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .HasMaxLength(50);

            this.Property(t => t.RealName)
                .HasMaxLength(20);

            this.Property(t => t.Email)
                .HasMaxLength(20);

            this.Property(t => t.Phone)
                .HasMaxLength(13);

            this.Property(t => t.UNIT_NO)
                .HasMaxLength(30);

            this.Property(t => t.CONT_NO)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("T_JC_Account");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CON_ACCE_ID).HasColumnName("CON_ACCE_ID");
            this.Property(t => t.BUSI_CUST_NO).HasColumnName("BUSI_CUST_NO");
            this.Property(t => t.Address_ID).HasColumnName("Address_ID");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.RealName).HasColumnName("RealName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.ActiveTime).HasColumnName("ActiveTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.IsEmailVerification).HasColumnName("IsEmailVerification");
            this.Property(t => t.IsPhoneVerification).HasColumnName("IsPhoneVerification");
            this.Property(t => t.UNIT_NO).HasColumnName("UNIT_NO");
            this.Property(t => t.CONT_NO).HasColumnName("CONT_NO");
        }
    }
}
