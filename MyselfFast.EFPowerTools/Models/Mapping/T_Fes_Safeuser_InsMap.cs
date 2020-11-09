using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_Safeuser_InsMap : EntityTypeConfiguration<T_Fes_Safeuser_Ins>
    {
        public T_Fes_Safeuser_InsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Sname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mobiles)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Comno)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ComnoSub)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Cid)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Pc)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("T_Fes_Safeuser_Ins");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.Sname).HasColumnName("Sname");
            this.Property(t => t.Mobiles).HasColumnName("Mobiles");
            this.Property(t => t.Comno).HasColumnName("Comno");
            this.Property(t => t.ComnoSub).HasColumnName("ComnoSub");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Pc).HasColumnName("Pc");
            this.Property(t => t.InsDate).HasColumnName("InsDate");
        }
    }
}
