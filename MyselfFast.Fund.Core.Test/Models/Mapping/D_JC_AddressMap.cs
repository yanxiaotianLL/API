using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.Collect.Core.Test.Models.Mapping
{
    public class D_JC_AddressMap : EntityTypeConfiguration<D_JC_Address>
    {
        public D_JC_AddressMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.area_name)
                .HasMaxLength(255);

            this.Property(t => t.creator_name)
                .HasMaxLength(255);

            this.Property(t => t.remark)
                .HasMaxLength(255);

            this.Property(t => t.area_type)
                .HasMaxLength(255);

            this.Property(t => t.area_type_dic)
                .HasMaxLength(255);

            this.Property(t => t.area_code)
                .HasMaxLength(255);

            this.Property(t => t.is_parent_menu)
                .HasMaxLength(255);

            this.Property(t => t.area_state_dic)
                .HasMaxLength(255);

            this.Property(t => t.area_nature_dic)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("D_JC_Address");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.area_id).HasColumnName("area_id");
            this.Property(t => t.parent_id).HasColumnName("parent_id");
            this.Property(t => t.area_name).HasColumnName("area_name");
            this.Property(t => t.creator_id).HasColumnName("creator_id");
            this.Property(t => t.creator_name).HasColumnName("creator_name");
            this.Property(t => t.remark).HasColumnName("remark");
            this.Property(t => t.area_type).HasColumnName("area_type");
            this.Property(t => t.area_type_dic).HasColumnName("area_type_dic");
            this.Property(t => t.area_code).HasColumnName("area_code");
            this.Property(t => t.leaf).HasColumnName("leaf");
            this.Property(t => t.is_parent_menu).HasColumnName("is_parent_menu");
            this.Property(t => t.level).HasColumnName("level");
            this.Property(t => t.area_state).HasColumnName("area_state");
            this.Property(t => t.area_state_dic).HasColumnName("area_state_dic");
            this.Property(t => t.area_nature).HasColumnName("area_nature");
            this.Property(t => t.area_nature_dic).HasColumnName("area_nature_dic");
            this.Property(t => t.order).HasColumnName("order");
            this.Property(t => t.operator).HasColumnName("operator");
            this.Property(t => t.oper_time).HasColumnName("oper_time");
        }
    }
}
