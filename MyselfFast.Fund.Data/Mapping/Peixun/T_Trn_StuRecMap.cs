//
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using myselfFast.Fund.Core.Domain.Peixun;

namespace myselfFast.Fund.Data.Mapping.Peixun
{
    public class T_Trn_StuRecMap : myselfFastEntityTypeConfiguration<T_Trn_StuRec>
    {
        public T_Trn_StuRecMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Trn_StuRec");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.IsFinish).HasColumnName("IsFinish");
            this.Property(t => t.RecPercent).HasColumnName("RecPercent");
            this.Property(t => t.LastPoint).HasColumnName("LastPoint");
            this.Property(t => t.FinishPct).HasColumnName("FinishPct");
            this.Property(t => t.CozInfoId).HasColumnName("CozInfoId");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}
