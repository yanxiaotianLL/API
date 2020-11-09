//
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using myselfFast.Fund.Core.Domain.Peixun;

namespace myselfFast.Fund.Data.Mapping.Peixun
{
    public class T_Trn_LabelMap : myselfFastEntityTypeConfiguration<T_Trn_Label>
    {
        public T_Trn_LabelMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.AliId)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Trn_Label");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.AliId).HasColumnName("AliId");
        }
    }
}
