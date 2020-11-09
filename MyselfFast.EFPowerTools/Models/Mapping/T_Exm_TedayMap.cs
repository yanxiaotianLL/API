using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_TedayMap : EntityTypeConfiguration<T_Exm_Teday>
    {
        public T_Exm_TedayMap()
        {
            // Primary Key
            this.HasKey(t => new { t.JigouId, t.CheckDate });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.JigouId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CheckDate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_Exm_Teday");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.JigouId).HasColumnName("JigouId");
            this.Property(t => t.CheckDate).HasColumnName("CheckDate");
            this.Property(t => t.Thisdaynum).HasColumnName("Thisdaynum");
            this.Property(t => t.Lastdaynum).HasColumnName("Lastdaynum");
            this.Property(t => t.BeforeDay).HasColumnName("BeforeDay");
            this.Property(t => t.Thisdaynum_Ind).HasColumnName("Thisdaynum_Ind");
            this.Property(t => t.Lastdaynum_Ind).HasColumnName("Lastdaynum_Ind");
            this.Property(t => t.appnum_male).HasColumnName("appnum_male");
            this.Property(t => t.appnum_female).HasColumnName("appnum_female");
        }
    }
}
