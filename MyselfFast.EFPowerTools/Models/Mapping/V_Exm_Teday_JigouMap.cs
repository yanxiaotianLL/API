using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_Exm_Teday_JigouMap : EntityTypeConfiguration<V_Exm_Teday_Jigou>
    {
        public V_Exm_Teday_JigouMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.JigouId, t.CheckDate, t.Thisdaynum, t.Lastdaynum, t.BeforeDay, t.Thisdaynum_Ind, t.Lastdaynum_Ind, t.appnum_male, t.appnum_female, t.JiGouName });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.JigouId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CheckDate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Thisdaynum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Lastdaynum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BeforeDay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Thisdaynum_Ind)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Lastdaynum_Ind)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.appnum_male)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.appnum_female)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.JiGouName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("V_Exm_Teday_Jigou");
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
            this.Property(t => t.JiGouName).HasColumnName("JiGouName");
        }
    }
}
