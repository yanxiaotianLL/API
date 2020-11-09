using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class vwdnt_usersMap : EntityTypeConfiguration<vwdnt_users>
    {
        public vwdnt_usersMap()
        {
            // Primary Key
            this.HasKey(t => new { t.uid, t.username });

            // Properties
            this.Property(t => t.uid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.username)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("vwdnt_users");
            this.Property(t => t.uid).HasColumnName("uid");
            this.Property(t => t.username).HasColumnName("username");
        }
    }
}
