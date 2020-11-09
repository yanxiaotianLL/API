using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_User_SafeCheckMap : EntityTypeConfiguration<T_Fes_User_SafeCheck>
    {
        public T_Fes_User_SafeCheckMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Uid)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(330);

            this.Property(t => t.Ltd)
                .IsRequired()
                .HasMaxLength(512);

            this.Property(t => t.Cid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Tel)
                .IsRequired()
                .HasMaxLength(26);

            this.Property(t => t.Imgs)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_Fes_User_SafeCheck");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Uid).HasColumnName("Uid");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Ltd).HasColumnName("Ltd");
            this.Property(t => t.Cardtype).HasColumnName("Cardtype");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Imgs).HasColumnName("Imgs");
        }
    }
}
