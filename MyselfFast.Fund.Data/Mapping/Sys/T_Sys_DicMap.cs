using myselfFast.Fund.Data.Mapping;
using myselfFast.ZFBZ.Core.Domain.Sys;

namespace myselfFast.ZFBZ.Data.Mapping
{
    public class T_Sys_DicMap : myselfFastEntityTypeConfiguration<T_Sys_Dic>
    {
        public T_Sys_DicMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(50);

            this.Property(t => t.ChineseName)
                .HasMaxLength(30);

            this.Property(t => t.EnglishName)
                .HasMaxLength(30);

            this.Property(t => t.DicType)
                .HasMaxLength(30);

            this.Property(t => t.DicTypeName)
                .HasMaxLength(30);

            this.Property(t => t.CreateUser)
                .HasMaxLength(20);

            this.Property(t => t.DicDetail)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Sys_Dic");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.ChineseName).HasColumnName("ChineseName");
            this.Property(t => t.EnglishName).HasColumnName("EnglishName");
            this.Property(t => t.DicType).HasColumnName("DicType");
            this.Property(t => t.DicTypeName).HasColumnName("DicTypeName");
            this.Property(t => t.SortValue).HasColumnName("SortValue");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.DicDetail).HasColumnName("DicDetail");

            this.Ignore(t => t.IsCarousel);
        }
    }
}