using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_User_RoleMap : EntityTypeConfiguration<T_Fes_User_Role>
    {
        public T_Fes_User_RoleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_Fes_User_Role");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Flable).HasColumnName("Flable");
            this.Property(t => t.Fesable).HasColumnName("Fesable");
            this.Property(t => t.Onsitable).HasColumnName("Onsitable");
            this.Property(t => t.Checkable).HasColumnName("Checkable");
            this.Property(t => t.Onsite_Create_On).HasColumnName("Onsite_Create_On");
            this.Property(t => t.Isdeleted).HasColumnName("Isdeleted");
            this.Property(t => t.Midicalable).HasColumnName("Midicalable");
        }
    }
}
