using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_GradeMap : EntityTypeConfiguration<T_Exm_Grade>
    {
        public T_Exm_GradeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CardNumber)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Exm_Grade");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Userid).HasColumnName("Userid");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.JigouId).HasColumnName("JigouId");
            this.Property(t => t.Environment).HasColumnName("Environment");
            this.Property(t => t.Service).HasColumnName("Service");
            this.Property(t => t.Averagetime).HasColumnName("Averagetime");
            this.Property(t => t.Doctorstandard).HasColumnName("Doctorstandard");
            this.Property(t => t.Breakfast).HasColumnName("Breakfast");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Createtime).HasColumnName("Createtime");
            this.Property(t => t.Average).HasColumnName("Average");
            this.Property(t => t.CardNumber).HasColumnName("CardNumber");
        }
    }
}
