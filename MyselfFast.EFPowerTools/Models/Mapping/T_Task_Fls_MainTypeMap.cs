using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Task_Fls_MainTypeMap : EntityTypeConfiguration<T_Task_Fls_MainType>
    {
        public T_Task_Fls_MainTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Fid, t.TypeId });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_Task_Fls_MainType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.OldId).HasColumnName("OldId");
        }
    }
}
