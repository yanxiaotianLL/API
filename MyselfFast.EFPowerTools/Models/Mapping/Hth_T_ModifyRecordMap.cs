using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_ModifyRecordMap : EntityTypeConfiguration<Hth_T_ModifyRecord>
    {
        public Hth_T_ModifyRecordMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OldData)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.NewData)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Hth_T_ModifyRecord");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.ImageId).HasColumnName("ImageId");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.OldData).HasColumnName("OldData");
            this.Property(t => t.NewData).HasColumnName("NewData");
            this.Property(t => t.AdminId).HasColumnName("AdminId");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
        }
    }
}
