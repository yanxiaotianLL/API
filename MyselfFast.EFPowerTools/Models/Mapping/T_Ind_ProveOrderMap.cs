using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Ind_ProveOrderMap : EntityTypeConfiguration<T_Ind_ProveOrder>
    {
        public T_Ind_ProveOrderMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.FesId, t.FesName, t.Hno, t.OrderType, t.Status, t.CreatDate, t.UpdateDate, t.StartDate, t.EndDate, t.ProveFesId, t.ProveFesName, t.proveState, t.ServiceCenterId, t.ServiceCenterName });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FesId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FesName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Hno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrderType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProveFesId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProveFesName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.proveState)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ServiceCenterId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ServiceCenterName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Ind_ProveOrder");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.FesName).HasColumnName("FesName");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.OrderType).HasColumnName("OrderType");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.CreatDate).HasColumnName("CreatDate");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.ProveFesId).HasColumnName("ProveFesId");
            this.Property(t => t.ProveFesName).HasColumnName("ProveFesName");
            this.Property(t => t.proveState).HasColumnName("proveState");
            this.Property(t => t.ServiceCenterId).HasColumnName("ServiceCenterId");
            this.Property(t => t.ServiceCenterName).HasColumnName("ServiceCenterName");
        }
    }
}
