using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_ZP_JobMap : EntityTypeConfiguration<T_ZP_Job>
    {
        public T_ZP_JobMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Jname)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Jinfo)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.jsalary)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("T_ZP_Job");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Jname).HasColumnName("Jname");
            this.Property(t => t.Jinfo).HasColumnName("Jinfo");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Jstu).HasColumnName("Jstu");
            this.Property(t => t.Jdate).HasColumnName("Jdate");
            this.Property(t => t.Jnum).HasColumnName("Jnum");
            this.Property(t => t.jsalary).HasColumnName("jsalary");
            this.Property(t => t.Endtime).HasColumnName("Endtime");
            this.Property(t => t.Checknum).HasColumnName("Checknum");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
        }
    }
}
