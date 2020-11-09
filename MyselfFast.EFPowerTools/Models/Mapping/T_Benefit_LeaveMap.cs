using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Benefit_LeaveMap : EntityTypeConfiguration<T_Benefit_Leave>
    {
        public T_Benefit_LeaveMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mark)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Leavetype)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Tel)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Leavecontent)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Back)
                .IsRequired()
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("T_Benefit_Leave");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Mark).HasColumnName("Mark");
            this.Property(t => t.Leavetype).HasColumnName("Leavetype");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Leavecontent).HasColumnName("Leavecontent");
            this.Property(t => t.Back).HasColumnName("Back");
            this.Property(t => t.Subtime).HasColumnName("Subtime");
            this.Property(t => t.Backtime).HasColumnName("Backtime");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
