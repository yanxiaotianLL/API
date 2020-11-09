using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Sys_FlroleMap : EntityTypeConfiguration<Sys_Flrole>
    {
        public Sys_FlroleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Fid, t.Rolename, t.Rolescript, t.Ishide });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Rolename)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Rolescript)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Sys_Flrole");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Rolename).HasColumnName("Rolename");
            this.Property(t => t.Rolescript).HasColumnName("Rolescript");
            this.Property(t => t.Ishide).HasColumnName("Ishide");
        }
    }
}
