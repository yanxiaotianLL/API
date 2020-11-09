//
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using myselfFast.Fund.Core.Domain.HuKouSettled;

namespace myselfFast.Fund.Data.Mapping.HuKouSettled
{
    public class T_HK_Settled_SpecdayMap : myselfFastEntityTypeConfiguration<T_HK_Settled_Specday>
    {
        public T_HK_Settled_SpecdayMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_HK_Settled_Specday");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.SpecType).HasColumnName("SpecType");
            this.Property(t => t.IsUse).HasColumnName("IsUse");
            this.Property(t => t.A).HasColumnName("A");
            this.Property(t => t.B).HasColumnName("B");
            this.Property(t => t.C).HasColumnName("C");
            this.Property(t => t.D).HasColumnName("D");
            this.Property(t => t.E).HasColumnName("E");
        }
    }
}
