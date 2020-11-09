using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Vote_ResaultMap : EntityTypeConfiguration<Vote_Resault>
    {
        public Vote_ResaultMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Vote_Resault");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Questionno).HasColumnName("Questionno");
            this.Property(t => t.Voteno).HasColumnName("Voteno");
            this.Property(t => t.Votenum).HasColumnName("Votenum");
        }
    }
}
