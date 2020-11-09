using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Email_ins_tailMap : EntityTypeConfiguration<T_Email_ins_tail>
    {
        public T_Email_ins_tailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.UseName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CreaterName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Email_ins_tail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PcId).HasColumnName("PcId");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.UseName).HasColumnName("UseName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CreaterId).HasColumnName("CreaterId");
            this.Property(t => t.CreaterName).HasColumnName("CreaterName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        }
    }
}
