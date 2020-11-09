using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Ind_DeliveryMap : EntityTypeConfiguration<T_Ind_Delivery>
    {
        public T_Ind_DeliveryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.DeliveryCompany)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DeliveryNum)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DeliveryAddress)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ActionPeopleName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Ind_Delivery");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.DeliveryType).HasColumnName("DeliveryType");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.DeliveryCompany).HasColumnName("DeliveryCompany");
            this.Property(t => t.DeliveryNum).HasColumnName("DeliveryNum");
            this.Property(t => t.DeliveryAddress).HasColumnName("DeliveryAddress");
            this.Property(t => t.ActionFesId).HasColumnName("ActionFesId");
            this.Property(t => t.ActionPeopleName).HasColumnName("ActionPeopleName");
            this.Property(t => t.IsFinished).HasColumnName("IsFinished");
            this.Property(t => t.AddressType).HasColumnName("AddressType");
            this.Property(t => t.FormalityId).HasColumnName("FormalityId");
        }
    }
}
