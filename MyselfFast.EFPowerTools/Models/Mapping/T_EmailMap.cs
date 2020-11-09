using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_EmailMap : EntityTypeConfiguration<T_Email>
    {
        public T_EmailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.links)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FiledList)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.Creatername)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Email");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.links).HasColumnName("links");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.FiledList).HasColumnName("FiledList");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Createrid).HasColumnName("Createrid");
            this.Property(t => t.Creatername).HasColumnName("Creatername");
            this.Property(t => t.Createtime).HasColumnName("Createtime");
        }
    }
}
