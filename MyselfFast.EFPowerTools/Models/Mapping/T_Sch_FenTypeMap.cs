using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sch_FenTypeMap : EntityTypeConfiguration<T_Sch_FenType>
    {
        public T_Sch_FenTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FenType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Miaoshu)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FenStans)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RoleName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.OperName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_Sch_FenType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FenType).HasColumnName("FenType");
            this.Property(t => t.Miaoshu).HasColumnName("Miaoshu");
            this.Property(t => t.FenStans).HasColumnName("FenStans");
            this.Property(t => t.Spread).HasColumnName("Spread");
            this.Property(t => t.Fenable).HasColumnName("Fenable");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.LmtTime).HasColumnName("LmtTime");
            this.Property(t => t.Belongto).HasColumnName("Belongto");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.RoleName).HasColumnName("RoleName");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperName).HasColumnName("OperName");
            this.Property(t => t.EditTime).HasColumnName("EditTime");
        }
    }
}
