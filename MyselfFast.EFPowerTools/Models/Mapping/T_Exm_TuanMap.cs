using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_TuanMap : EntityTypeConfiguration<T_Exm_Tuan>
    {
        public T_Exm_TuanMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Script)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.EditerName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Exm_Tuan");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Script).HasColumnName("Script");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.EditerId).HasColumnName("EditerId");
            this.Property(t => t.EditerName).HasColumnName("EditerName");
            this.Property(t => t.EditTime).HasColumnName("EditTime");
        }
    }
}
