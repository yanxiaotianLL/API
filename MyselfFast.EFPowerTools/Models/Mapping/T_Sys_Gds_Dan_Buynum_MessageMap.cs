using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sys_Gds_Dan_Buynum_MessageMap : EntityTypeConfiguration<T_Sys_Gds_Dan_Buynum_Message>
    {
        public T_Sys_Gds_Dan_Buynum_MessageMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Sys_Gds_Dan_Buynum_Message");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Memsour).HasColumnName("Memsour");
            this.Property(t => t.Orderid).HasColumnName("Orderid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Planid).HasColumnName("Planid");
            this.Property(t => t.Chgnum).HasColumnName("Chgnum");
            this.Property(t => t.Gendate).HasColumnName("Gendate");
            this.Property(t => t.Checkdate).HasColumnName("Checkdate");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
