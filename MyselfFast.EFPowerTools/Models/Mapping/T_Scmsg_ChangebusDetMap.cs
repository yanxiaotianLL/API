using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Scmsg_ChangebusDetMap : EntityTypeConfiguration<T_Scmsg_ChangebusDet>
    {
        public T_Scmsg_ChangebusDetMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.OldContent)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.NewContent)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_Scmsg_ChangebusDet");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BusId).HasColumnName("BusId");
            this.Property(t => t.OldNo).HasColumnName("OldNo");
            this.Property(t => t.OldContent).HasColumnName("OldContent");
            this.Property(t => t.NewNo).HasColumnName("NewNo");
            this.Property(t => t.NewContent).HasColumnName("NewContent");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        }
    }
}
