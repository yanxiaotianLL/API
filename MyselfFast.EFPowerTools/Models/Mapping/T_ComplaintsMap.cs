using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_ComplaintsMap : EntityTypeConfiguration<T_Complaints>
    {
        public T_ComplaintsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Danid, t.Username, t.Title, t.Sort, t.Content1, t.Content2, t.Back1, t.Back2, t.Subtime1, t.Subtime2, t.Backtime1, t.Backtime2, t.Isback, t.Pic1, t.Pic2, t.Pic3, t.Pic4, t.Status, t.Backusername1, t.Backusername2, t.Xuhao, t.Hid });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Danid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Username)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Sort)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Content1)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Content2)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Back1)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Back2)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Isback)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.Status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Backusername1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Backusername2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Xuhao)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Hid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_Complaints");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Danid).HasColumnName("Danid");
            this.Property(t => t.Username).HasColumnName("Username");
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
        }
    }
}
