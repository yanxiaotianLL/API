using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Ind_TokenMap : EntityTypeConfiguration<T_Ind_Token>
    {
        public T_Ind_TokenMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CurrentPlace)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.DeliveryAddress)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_Ind_Token");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.TakeTokenType).HasColumnName("TakeTokenType");
            this.Property(t => t.CurrentPlace).HasColumnName("CurrentPlace");
            this.Property(t => t.DeliveryAddress).HasColumnName("DeliveryAddress");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.DeliveryId).HasColumnName("DeliveryId");
            this.Property(t => t.IsMerge).HasColumnName("IsMerge");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.DeliveryAddType).HasColumnName("DeliveryAddType");
            this.Property(t => t.FormalityId).HasColumnName("FormalityId");
        }
    }
}
