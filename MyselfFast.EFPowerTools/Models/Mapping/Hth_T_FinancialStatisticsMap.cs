using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_FinancialStatisticsMap : EntityTypeConfiguration<Hth_T_FinancialStatistics>
    {
        public Hth_T_FinancialStatisticsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Hth_T_FinancialStatistics");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AdminId).HasColumnName("AdminId");
            this.Property(t => t.StartDatetime).HasColumnName("StartDatetime");
            this.Property(t => t.EndDatetime).HasColumnName("EndDatetime");
            this.Property(t => t.CreateDatetime).HasColumnName("CreateDatetime");
            this.Property(t => t.JianGuanCount).HasColumnName("JianGuanCount");
            this.Property(t => t.OnsiteCount).HasColumnName("OnsiteCount");
            this.Property(t => t.NoEntityCount).HasColumnName("NoEntityCount");
            this.Property(t => t.AllCount).HasColumnName("AllCount");
        }
    }
}
