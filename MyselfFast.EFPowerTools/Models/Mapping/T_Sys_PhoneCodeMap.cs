using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sys_PhoneCodeMap : EntityTypeConfiguration<T_Sys_PhoneCode>
    {
        public T_Sys_PhoneCodeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Phone)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Ip)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ToUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FromUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Sys_PhoneCode");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Ip).HasColumnName("Ip");
            this.Property(t => t.ToUser).HasColumnName("ToUser");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.FromUser).HasColumnName("FromUser");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UseTime).HasColumnName("UseTime");
        }
    }
}
