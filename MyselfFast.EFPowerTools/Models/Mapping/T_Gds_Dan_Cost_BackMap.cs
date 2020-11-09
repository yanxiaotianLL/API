using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_Dan_Cost_BackMap : EntityTypeConfiguration<T_Gds_Dan_Cost_Back>
    {
        public T_Gds_Dan_Cost_BackMap()
        {
            // Primary Key
            this.HasKey(t => t.Msgid);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Msgid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_Gds_Dan_Cost_Back");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Msgid).HasColumnName("Msgid");
            this.Property(t => t.Gendate).HasColumnName("Gendate");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
