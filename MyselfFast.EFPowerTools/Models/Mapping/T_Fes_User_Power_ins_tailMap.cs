using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_User_Power_ins_tailMap : EntityTypeConfiguration<T_Fes_User_Power_ins_tail>
    {
        public T_Fes_User_Power_ins_tailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Fes_User_Power_ins_tail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Pcid).HasColumnName("Pcid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.ImportTime).HasColumnName("ImportTime");
        }
    }
}
