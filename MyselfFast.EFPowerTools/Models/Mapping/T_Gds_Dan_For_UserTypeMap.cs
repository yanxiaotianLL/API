using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_Dan_For_UserTypeMap : EntityTypeConfiguration<T_Gds_Dan_For_UserType>
    {
        public T_Gds_Dan_For_UserTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Gds_Dan_For_UserType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Orderid).HasColumnName("Orderid");
            this.Property(t => t.Part).HasColumnName("Part");
        }
    }
}
