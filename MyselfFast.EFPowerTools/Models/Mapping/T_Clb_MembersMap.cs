using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Clb_MembersMap : EntityTypeConfiguration<T_Clb_Members>
    {
        public T_Clb_MembersMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Clb_Members");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Clubid).HasColumnName("Clubid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Roleid).HasColumnName("Roleid");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
