using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Onl_Prove_TailMap : EntityTypeConfiguration<T_Onl_Prove_Tail>
    {
        public T_Onl_Prove_TailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Mtypename)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Typename)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Usedname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Timeslot)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Onl_Prove_Tail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.Mtypeid).HasColumnName("Mtypeid");
            this.Property(t => t.Mtypename).HasColumnName("Mtypename");
            this.Property(t => t.Typeid).HasColumnName("Typeid");
            this.Property(t => t.Typename).HasColumnName("Typename");
            this.Property(t => t.Usedid).HasColumnName("Usedid");
            this.Property(t => t.Usedname).HasColumnName("Usedname");
            this.Property(t => t.Timeslot).HasColumnName("Timeslot");
            this.Property(t => t.ISReflect).HasColumnName("ISReflect");
        }
    }
}
