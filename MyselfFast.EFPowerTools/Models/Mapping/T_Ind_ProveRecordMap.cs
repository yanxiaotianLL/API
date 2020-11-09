using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Ind_ProveRecordMap : EntityTypeConfiguration<T_Ind_ProveRecord>
    {
        public T_Ind_ProveRecordMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.FesId, t.OrderId, t.Detail, t.Status, t.CreateDate, t.UpdateDate, t.StartDate, t.EndDate, t.ProveFesId, t.ProveFesName });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FesId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrderId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Detail)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProveFesId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProveFesName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Ind_ProveRecord");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.Detail).HasColumnName("Detail");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.ProveFesId).HasColumnName("ProveFesId");
            this.Property(t => t.ProveFesName).HasColumnName("ProveFesName");
        }
    }
}
