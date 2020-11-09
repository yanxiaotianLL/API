using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_Jigou_testMap : EntityTypeConfiguration<T_Exm_Jigou_test>
    {
        public T_Exm_Jigou_testMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.EName)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Tel)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.OpenTime)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.ParentName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Province)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CloseDateId)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.CloseDate)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Coordinate)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RouteMap)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_Exm_Jigou_test");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.EName).HasColumnName("EName");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.OpenTime).HasColumnName("OpenTime");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.ParentName).HasColumnName("ParentName");
            this.Property(t => t.ProvinceId).HasColumnName("ProvinceId");
            this.Property(t => t.Province).HasColumnName("Province");
            this.Property(t => t.CityId).HasColumnName("CityId");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.CloseDateId).HasColumnName("CloseDateId");
            this.Property(t => t.CloseDate).HasColumnName("CloseDate");
            this.Property(t => t.Appnum).HasColumnName("Appnum");
            this.Property(t => t.Coordinate).HasColumnName("Coordinate");
            this.Property(t => t.RouteMap).HasColumnName("RouteMap");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
        }
    }
}
