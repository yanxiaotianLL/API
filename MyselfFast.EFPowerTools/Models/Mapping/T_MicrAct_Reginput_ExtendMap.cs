using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_MicrAct_Reginput_ExtendMap : EntityTypeConfiguration<T_MicrAct_Reginput_Extend>
    {
        public T_MicrAct_Reginput_ExtendMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.InputLabel)
                .HasMaxLength(20);

            this.Property(t => t.InputValue)
                .HasMaxLength(200);

            this.Property(t => t.Description)
                .HasMaxLength(200);

            this.Property(t => t.CreateUser)
                .HasMaxLength(50);

            this.Property(t => t.UpdateUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_MicrAct_Reginput_Extend");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ActiveID).HasColumnName("ActiveID");
            this.Property(t => t.InputType).HasColumnName("InputType");
            this.Property(t => t.InputLabel).HasColumnName("InputLabel");
            this.Property(t => t.InputValue).HasColumnName("InputValue");
            this.Property(t => t.IsRequired).HasColumnName("IsRequired");
            this.Property(t => t.Enable).HasColumnName("Enable");
            this.Property(t => t.InputSort).HasColumnName("InputSort");
            this.Property(t => t.PersonIndex).HasColumnName("PersonIndex");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.FieldType).HasColumnName("FieldType");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.UpdateUser).HasColumnName("UpdateUser");
        }
    }
}
