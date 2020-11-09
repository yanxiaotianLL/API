using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_Sch_Plan_UserMap : EntityTypeConfiguration<V_Sch_Plan_User>
    {
        public V_Sch_Plan_UserMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Planid, t.Fid, t.Fesid, t.SchNum, t.Buynum, t.LmtStart, t.LmtEnd, t.State });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Planid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fesid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SchNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Buynum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("V_Sch_Plan_User");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Planid).HasColumnName("Planid");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.SchNum).HasColumnName("SchNum");
            this.Property(t => t.Buynum).HasColumnName("Buynum");
            this.Property(t => t.LmtStart).HasColumnName("LmtStart");
            this.Property(t => t.LmtEnd).HasColumnName("LmtEnd");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
