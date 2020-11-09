using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_Task_Fls_MainTypeMap : EntityTypeConfiguration<V_Task_Fls_MainType>
    {
        public V_Task_Fls_MainTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Fid, t.TypeId, t.Tasktype, t.Isdelete });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Tasktype)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("V_Task_Fls_MainType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.Tasktype).HasColumnName("Tasktype");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
        }
    }
}
