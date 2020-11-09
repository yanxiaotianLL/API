//
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using myselfFast.Fund.Core.Domain.Hukou;

namespace myselfFast.Fund.Data.Mapping.Hukou
{
    public class T_HK_HuKou_NumMap : myselfFastEntityTypeConfiguration<T_HK_HuKou_Num>
    {
        public T_HK_HuKou_NumMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Useage)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("T_HK_HuKou_Num");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BusinessId).HasColumnName("BusinessId");
            this.Property(t => t.UseageId).HasColumnName("UseageId");
            this.Property(t => t.Useage).HasColumnName("Useage");
            this.Property(t => t.Num).HasColumnName("Num");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        }
    }
}
