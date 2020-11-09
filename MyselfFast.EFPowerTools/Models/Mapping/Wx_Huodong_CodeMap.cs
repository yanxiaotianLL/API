using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Wx_Huodong_CodeMap : EntityTypeConfiguration<Wx_Huodong_Code>
    {
        public Wx_Huodong_CodeMap()
        {
            // Primary Key
            this.HasKey(t => t.Code);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Aid)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Supplier)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Gys)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Open_Id)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Wx_Huodong_Code");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Aid).HasColumnName("Aid");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Supplier).HasColumnName("Supplier");
            this.Property(t => t.Gys).HasColumnName("Gys");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Open_Id).HasColumnName("Open_Id");
        }
    }
}
