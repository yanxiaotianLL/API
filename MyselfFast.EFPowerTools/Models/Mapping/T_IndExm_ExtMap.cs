using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_IndExm_ExtMap : EntityTypeConfiguration<T_IndExm_Ext>
    {
        public T_IndExm_ExtMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_IndExm_Ext");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.DetailID).HasColumnName("DetailID");
            this.Property(t => t.FormalityID).HasColumnName("FormalityID");
            this.Property(t => t.HasOnline).HasColumnName("HasOnline");
            this.Property(t => t.HasUpload).HasColumnName("HasUpload");
            this.Property(t => t.HasConfirmService).HasColumnName("HasConfirmService");
            this.Property(t => t.NewSysPID).HasColumnName("NewSysPID");
            this.Property(t => t.PackageId).HasColumnName("PackageId");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        }
    }
}
