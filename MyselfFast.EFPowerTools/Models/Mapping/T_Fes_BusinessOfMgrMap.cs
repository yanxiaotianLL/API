using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_BusinessOfMgrMap : EntityTypeConfiguration<T_Fes_BusinessOfMgr>
    {
        public T_Fes_BusinessOfMgrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Mid, t.custId, t.busiCustId });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Mid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.custId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.busiCustId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_Fes_BusinessOfMgr");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Mid).HasColumnName("Mid");
            this.Property(t => t.custId).HasColumnName("custId");
            this.Property(t => t.busiCustId).HasColumnName("busiCustId");
        }
    }
}
