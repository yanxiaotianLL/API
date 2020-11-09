using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_Que_WakeMap : EntityTypeConfiguration<V_Que_Wake>
    {
        public V_Que_WakeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Hid, t.Cname, t.PlanId, t.PlanName, t.Ys1, t.Ys1name, t.Ys2, t.Ys2name, t.Kucun });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Hid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.PlanId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PlanName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Ys1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ys1name)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Ys2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ys2name)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Kucun)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("V_Que_Wake");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Hid).HasColumnName("Hid");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.PlanId).HasColumnName("PlanId");
            this.Property(t => t.PlanName).HasColumnName("PlanName");
            this.Property(t => t.Ys1).HasColumnName("Ys1");
            this.Property(t => t.Ys1name).HasColumnName("Ys1name");
            this.Property(t => t.Ys2).HasColumnName("Ys2");
            this.Property(t => t.Ys2name).HasColumnName("Ys2name");
            this.Property(t => t.Kucun).HasColumnName("Kucun");
        }
    }
}
