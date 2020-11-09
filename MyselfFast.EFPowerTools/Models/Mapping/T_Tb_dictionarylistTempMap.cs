using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Tb_dictionarylistTempMap : EntityTypeConfiguration<T_Tb_dictionarylistTemp>
    {
        public T_Tb_dictionarylistTempMap()
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

            this.Property(t => t.dcodeNew)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.dnameNew)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Tb_dictionarylistTemp");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.dcode).HasColumnName("dcode");
            this.Property(t => t.dname_en).HasColumnName("dname_en");
            this.Property(t => t.dname).HasColumnName("dname");
            this.Property(t => t.dtype).HasColumnName("dtype");
            this.Property(t => t.dcodeNew).HasColumnName("dcodeNew");
            this.Property(t => t.dnameNew).HasColumnName("dnameNew");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        }
    }
}
