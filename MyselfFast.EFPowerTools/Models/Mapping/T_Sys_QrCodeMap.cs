using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sys_QrCodeMap : EntityTypeConfiguration<T_Sys_QrCode>
    {
        public T_Sys_QrCodeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.QrPicName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FunctionType)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.SubFunctionType)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Sys_QrCode");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.QrPicName).HasColumnName("QrPicName");
            this.Property(t => t.FunctionType).HasColumnName("FunctionType");
            this.Property(t => t.SubFunctionType).HasColumnName("SubFunctionType");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
