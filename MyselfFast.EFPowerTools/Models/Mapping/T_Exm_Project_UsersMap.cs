using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_Project_UsersMap : EntityTypeConfiguration<T_Exm_Project_Users>
    {
        public T_Exm_Project_UsersMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cardno)
                .IsRequired()
                .HasMaxLength(18);

            // Table & Column Mappings
            this.ToTable("T_Exm_Project_Users");
            this.Property(t => t.Projectid).HasColumnName("Projectid");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Cardno).HasColumnName("Cardno");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Iscard).HasColumnName("Iscard");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}
