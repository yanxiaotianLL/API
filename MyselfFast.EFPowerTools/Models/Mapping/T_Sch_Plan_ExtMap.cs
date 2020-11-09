using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sch_Plan_ExtMap : EntityTypeConfiguration<T_Sch_Plan_Ext>
    {
        public T_Sch_Plan_ExtMap()
        {
            // Primary Key
            this.HasKey(t => t.Planid);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Planid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Calculation)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("T_Sch_Plan_Ext");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Planid).HasColumnName("Planid");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Costprice).HasColumnName("Costprice");
            this.Property(t => t.Interrate).HasColumnName("Interrate");
            this.Property(t => t.PriceId).HasColumnName("PriceId");
            this.Property(t => t.Bckmnyable).HasColumnName("Bckmnyable");
            this.Property(t => t.Calculation).HasColumnName("Calculation");
        }
    }
}
