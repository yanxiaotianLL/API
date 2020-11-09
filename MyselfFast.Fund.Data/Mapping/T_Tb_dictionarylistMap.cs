//
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using myselfFast.Fund.Core.Domain.Hukou;
using myselfFast.Fund.Core.Domain;

namespace myselfFast.Fund.Data.Mapping.Hukou
{
    public class T_Tb_dictionarylistMap : myselfFastEntityTypeConfiguration<T_Tb_dictionarylist>
    {
        public T_Tb_dictionarylistMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.dcode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.dname_en)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.dname)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Tb_dictionarylist");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.dcode).HasColumnName("dcode");
            this.Property(t => t.dname_en).HasColumnName("dname_en");
            this.Property(t => t.dname).HasColumnName("dname");
            this.Property(t => t.dtype).HasColumnName("dtype");
        }
    }
}
