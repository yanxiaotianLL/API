using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_Fls_BusMap : EntityTypeConfiguration<T_Fes_Fls_Bus>
    {
        public T_Fes_Fls_BusMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Fes_Fls_Bus");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Pid).HasColumnName("Pid");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.busiCustId).HasColumnName("busiCustId");
        }
    }
}
