using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Rpt_OperMap : EntityTypeConfiguration<T_Rpt_Oper>
    {
        public T_Rpt_OperMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Rpt_Oper");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.DefId).HasColumnName("DefId");
        }
    }
}
