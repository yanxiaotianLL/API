using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Tb_User_Ext5Map : EntityTypeConfiguration<T_Tb_User_Ext5>
    {
        public T_Tb_User_Ext5Map()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Idx });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Idx)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.变更项目)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.变更前内容)
                .IsRequired()
                .HasMaxLength(800);

            this.Property(t => t.变更后内容)
                .IsRequired()
                .HasMaxLength(800);

            // Table & Column Mappings
            this.ToTable("T_Tb_User_Ext5");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Idx).HasColumnName("Idx");
            this.Property(t => t.变更项目).HasColumnName("变更项目");
            this.Property(t => t.变更前内容).HasColumnName("变更前内容");
            this.Property(t => t.变更后内容).HasColumnName("变更后内容");
        }
    }
}
