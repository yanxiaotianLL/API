using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Act_Reginput_ExtendMap : EntityTypeConfiguration<T_Act_Reginput_Extend>
    {
        public T_Act_Reginput_ExtendMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.InputLabel)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.InputValue)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("T_Act_Reginput_Extend");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Activeid).HasColumnName("Activeid");
            this.Property(t => t.InputType).HasColumnName("InputType");
            this.Property(t => t.InputLabel).HasColumnName("InputLabel");
            this.Property(t => t.InputValue).HasColumnName("InputValue");
            this.Property(t => t.IsRequired).HasColumnName("IsRequired");
            this.Property(t => t.Enable).HasColumnName("Enable");
            this.Property(t => t.InputSort).HasColumnName("InputSort");
            this.Property(t => t.PersonIndex).HasColumnName("PersonIndex");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.FieldType).HasColumnName("FieldType");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
        }
    }
}
