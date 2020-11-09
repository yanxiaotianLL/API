using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_Gds_Col_RlMap : EntityTypeConfiguration<V_Gds_Col_Rl>
    {
        public V_Gds_Col_RlMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.PlanId, t.Cid, t.Grd, t.Cname, t.Ename, t.Script, t.Img, t.Idx, t.Isdbl, t.Links, t.Showtype, t.State, t.Frontimg, t.PID3, t.CID3, t.PID2, t.CID2, t.PID1, t.CID1 });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PlanId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Cid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Grd)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Ename)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Script)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Img)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Idx)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Links)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Showtype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Frontimg)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.PID3)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CID3)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PID2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CID2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PID1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CID1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("V_Gds_Col_Rl");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PlanId).HasColumnName("PlanId");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Grd).HasColumnName("Grd");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Ename).HasColumnName("Ename");
            this.Property(t => t.Script).HasColumnName("Script");
            this.Property(t => t.Img).HasColumnName("Img");
            this.Property(t => t.Idx).HasColumnName("Idx");
            this.Property(t => t.Isdbl).HasColumnName("Isdbl");
            this.Property(t => t.Links).HasColumnName("Links");
            this.Property(t => t.Showtype).HasColumnName("Showtype");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Frontimg).HasColumnName("Frontimg");
            this.Property(t => t.PID3).HasColumnName("PID3");
            this.Property(t => t.CID3).HasColumnName("CID3");
            this.Property(t => t.PID2).HasColumnName("PID2");
            this.Property(t => t.CID2).HasColumnName("CID2");
            this.Property(t => t.PID1).HasColumnName("PID1");
            this.Property(t => t.CID1).HasColumnName("CID1");
        }
    }
}
