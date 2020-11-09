using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Imp_DefaultOrder_TailMap : EntityTypeConfiguration<T_Imp_DefaultOrder_Tail>
    {
        public T_Imp_DefaultOrder_TailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ErrorMsg)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Imp_DefaultOrder_Tail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Pc).HasColumnName("Pc");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.ErrorMsg).HasColumnName("ErrorMsg");
        }
    }
}
