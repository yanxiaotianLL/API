using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_Sys_Locked_TableMap : EntityTypeConfiguration<V_Sys_Locked_Table>
    {
        public V_Sys_Locked_TableMap()
        {
            // Primary Key
            this.HasKey(t => t.spid);

            // Properties
            this.Property(t => t.spid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tableName)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("V_Sys_Locked_Table");
            this.Property(t => t.spid).HasColumnName("spid");
            this.Property(t => t.tableName).HasColumnName("tableName");
        }
    }
}
