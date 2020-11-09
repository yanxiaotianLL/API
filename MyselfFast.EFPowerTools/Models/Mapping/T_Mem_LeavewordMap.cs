using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Mem_LeavewordMap : EntityTypeConfiguration<T_Mem_Leaveword>
    {
        public T_Mem_LeavewordMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Sort)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Content1)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.Content2)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.Back1)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.Back2)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.Pic1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Pic2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Pic3)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Pic4)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Backusername1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Backusername2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Tel)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Userkey)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Yewubu)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Sortview)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mark)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_Mem_Leaveword");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Danid).HasColumnName("Danid");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.Content1).HasColumnName("Content1");
            this.Property(t => t.Content2).HasColumnName("Content2");
            this.Property(t => t.Back1).HasColumnName("Back1");
            this.Property(t => t.Back2).HasColumnName("Back2");
            this.Property(t => t.Subtime1).HasColumnName("Subtime1");
            this.Property(t => t.Subtime2).HasColumnName("Subtime2");
            this.Property(t => t.Backtime1).HasColumnName("Backtime1");
            this.Property(t => t.Backtime2).HasColumnName("Backtime2");
            this.Property(t => t.Isback).HasColumnName("Isback");
            this.Property(t => t.Pic1).HasColumnName("Pic1");
            this.Property(t => t.Pic2).HasColumnName("Pic2");
            this.Property(t => t.Pic3).HasColumnName("Pic3");
            this.Property(t => t.Pic4).HasColumnName("Pic4");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Backusername1).HasColumnName("Backusername1");
            this.Property(t => t.Backusername2).HasColumnName("Backusername2");
            this.Property(t => t.Xuhao).HasColumnName("Xuhao");
            this.Property(t => t.Hid).HasColumnName("Hid");
            this.Property(t => t.Readflag).HasColumnName("Readflag");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Userkey).HasColumnName("Userkey");
            this.Property(t => t.Yewubu).HasColumnName("Yewubu");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Sortview).HasColumnName("Sortview");
            this.Property(t => t.Mark).HasColumnName("Mark");
            this.Property(t => t.Used).HasColumnName("Used");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
        }
    }
}
