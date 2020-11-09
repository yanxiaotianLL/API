using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_User_Power_insMap : EntityTypeConfiguration<T_Fes_User_Power_ins>
    {
        public T_Fes_User_Power_insMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Pc)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CreaterName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Fes_User_Power_ins");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.PowerType).HasColumnName("PowerType");
            this.Property(t => t.Optype).HasColumnName("Optype");
            this.Property(t => t.Pc).HasColumnName("Pc");
            this.Property(t => t.CreaterId).HasColumnName("CreaterId");
            this.Property(t => t.CreaterName).HasColumnName("CreaterName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        }
    }
}
