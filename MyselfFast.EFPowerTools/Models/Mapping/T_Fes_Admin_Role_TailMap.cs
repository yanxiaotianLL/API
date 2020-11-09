using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_Admin_Role_TailMap : EntityTypeConfiguration<T_Fes_Admin_Role_Tail>
    {
        public T_Fes_Admin_Role_TailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Fes_Admin_Role_Tail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.MenuId).HasColumnName("MenuId");
            this.Property(t => t.Guid).HasColumnName("Guid");
            this.Property(t => t.EditAble).HasColumnName("EditAble");
            this.Property(t => t.AuditAble).HasColumnName("AuditAble");
            this.Property(t => t.DelAble).HasColumnName("DelAble");
        }
    }
}
