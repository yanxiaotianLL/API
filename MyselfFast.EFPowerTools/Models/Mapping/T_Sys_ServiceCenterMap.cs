using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sys_ServiceCenterMap : EntityTypeConfiguration<T_Sys_ServiceCenter>
    {
        public T_Sys_ServiceCenterMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BusinessDep)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.SerCenterName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.SerCenterAdd)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ContactUser)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ContactMobel)
                .HasMaxLength(110);

            this.Property(t => t.SerCenPhone)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("T_Sys_ServiceCenter");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BusinessDep).HasColumnName("BusinessDep");
            this.Property(t => t.SerCenterName).HasColumnName("SerCenterName");
            this.Property(t => t.SerCenterAdd).HasColumnName("SerCenterAdd");
            this.Property(t => t.ContactUser).HasColumnName("ContactUser");
            this.Property(t => t.ContactMobel).HasColumnName("ContactMobel");
            this.Property(t => t.SerCenPhone).HasColumnName("SerCenPhone");
        }
    }
}
