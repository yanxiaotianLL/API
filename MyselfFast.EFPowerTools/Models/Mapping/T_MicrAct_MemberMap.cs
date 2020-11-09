using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_MicrAct_MemberMap : EntityTypeConfiguration<T_MicrAct_Member>
    {
        public T_MicrAct_MemberMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.IDCard)
                .HasMaxLength(200);

            this.Property(t => t.Tel)
                .HasMaxLength(50);

            this.Property(t => t.Company)
                .HasMaxLength(200);

            this.Property(t => t.Email)
                .HasMaxLength(200);

            this.Property(t => t.Postcode)
                .HasMaxLength(10);

            this.Property(t => t.Address)
                .HasMaxLength(200);

            this.Property(t => t.CreateUser)
                .HasMaxLength(50);

            this.Property(t => t.UpdateUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_MicrAct_Member");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RegistrationID).HasColumnName("RegistrationID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.IDCard).HasColumnName("IDCard");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.Postcode).HasColumnName("Postcode");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.UpdateUser).HasColumnName("UpdateUser");
        }
    }
}
