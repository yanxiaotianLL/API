using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Ind_GuideMap : EntityTypeConfiguration<T_Ind_Guide>
    {
        public T_Ind_GuideMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.FesId, t.IsInsurance, t.DomicileType, t.FilePlace, t.IsChange, t.CreateDate, t.UpdateDate });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FesId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsInsurance)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DomicileType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FilePlace)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsChange)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_Ind_Guide");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.IsInsurance).HasColumnName("IsInsurance");
            this.Property(t => t.DomicileType).HasColumnName("DomicileType");
            this.Property(t => t.FilePlace).HasColumnName("FilePlace");
            this.Property(t => t.IsChange).HasColumnName("IsChange");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
        }
    }
}
