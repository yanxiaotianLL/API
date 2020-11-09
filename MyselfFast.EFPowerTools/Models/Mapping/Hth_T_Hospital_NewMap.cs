using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_Hospital_NewMap : EntityTypeConfiguration<Hth_T_Hospital_New>
    {
        public Hth_T_Hospital_NewMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.Code)
                .HasMaxLength(20);

            this.Property(t => t.Province)
                .HasMaxLength(50);

            this.Property(t => t.City)
                .HasMaxLength(50);

            this.Property(t => t.Grade)
                .HasMaxLength(20);

            this.Property(t => t.Remark)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Hth_T_Hospital_New");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Province).HasColumnName("Province");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Grade).HasColumnName("Grade");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.ModifyDate).HasColumnName("ModifyDate");
        }
    }
}
