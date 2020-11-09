using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Task_Menu_Ext_FlsMap : EntityTypeConfiguration<T_Task_Menu_Ext_Fls>
    {
        public T_Task_Menu_Ext_FlsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Fid, t.Mid });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Mid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_Task_Menu_Ext_Fls");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Mid).HasColumnName("Mid");
        }
    }
}
