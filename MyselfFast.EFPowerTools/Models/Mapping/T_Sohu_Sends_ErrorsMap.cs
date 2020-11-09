using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sohu_Sends_ErrorsMap : EntityTypeConfiguration<T_Sohu_Sends_Errors>
    {
        public T_Sohu_Sends_ErrorsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ErrorText)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_Sohu_Sends_Errors");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Danid).HasColumnName("Danid");
            this.Property(t => t.SendDate).HasColumnName("SendDate");
            this.Property(t => t.ErrorText).HasColumnName("ErrorText");
        }
    }
}
