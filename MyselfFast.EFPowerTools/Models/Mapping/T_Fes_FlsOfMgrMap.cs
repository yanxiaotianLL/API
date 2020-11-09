using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_FlsOfMgrMap : EntityTypeConfiguration<T_Fes_FlsOfMgr>
    {
        public T_Fes_FlsOfMgrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Mid, t.Fid });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Mid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_Fes_FlsOfMgr");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Mid).HasColumnName("Mid");
            this.Property(t => t.Fid).HasColumnName("Fid");
        }
    }
}
