using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Vote_InfoMap : EntityTypeConfiguration<Vote_Info>
    {
        public Vote_InfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Username)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Seventhvote)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Eighthvote)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Vote_Info");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.Firstvote).HasColumnName("Firstvote");
            this.Property(t => t.Secondvote).HasColumnName("Secondvote");
            this.Property(t => t.Thirdvote).HasColumnName("Thirdvote");
            this.Property(t => t.Forthvote).HasColumnName("Forthvote");
            this.Property(t => t.Fifthvote).HasColumnName("Fifthvote");
            this.Property(t => t.Sixthvote).HasColumnName("Sixthvote");
            this.Property(t => t.Seventhvote).HasColumnName("Seventhvote");
            this.Property(t => t.Eighthvote).HasColumnName("Eighthvote");
            this.Property(t => t.Votetime).HasColumnName("Votetime");
        }
    }
}
