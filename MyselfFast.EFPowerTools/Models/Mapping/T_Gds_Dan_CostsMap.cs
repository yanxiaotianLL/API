using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_Dan_CostsMap : EntityTypeConfiguration<T_Gds_Dan_Costs>
    {
        public T_Gds_Dan_CostsMap()
        {
            // Primary Key
            this.HasKey(t => t.Danid);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Danid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Danno)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Gds_Dan_Costs");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Danid).HasColumnName("Danid");
            this.Property(t => t.Danno).HasColumnName("Danno");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Gendate).HasColumnName("Gendate");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
