using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class RenzhengdataMap : EntityTypeConfiguration<Renzhengdata>
    {
        public RenzhengdataMap()
        {
            // Primary Key
            this.HasKey(t => t.Zjnumber);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Khid)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Khname)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Real_Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Employee_Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Zjnumber)
                .IsRequired()
                .HasMaxLength(24);

            this.Property(t => t.Employee_Code)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Contact_Tel1)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Contact_Tel2)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.E_Mail)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.State)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Renzhengdata");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Khid).HasColumnName("Khid");
            this.Property(t => t.Khname).HasColumnName("Khname");
            this.Property(t => t.Real_Name).HasColumnName("Real_Name");
            this.Property(t => t.Employee_Name).HasColumnName("Employee_Name");
            this.Property(t => t.Zjnumber).HasColumnName("Zjnumber");
            this.Property(t => t.Employee_Code).HasColumnName("Employee_Code");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Contact_Tel1).HasColumnName("Contact_Tel1");
            this.Property(t => t.Contact_Tel2).HasColumnName("Contact_Tel2");
            this.Property(t => t.E_Mail).HasColumnName("E_Mail");
            this.Property(t => t.Indate).HasColumnName("Indate");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
