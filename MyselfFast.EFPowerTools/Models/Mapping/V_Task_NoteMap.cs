using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_Task_NoteMap : EntityTypeConfiguration<V_Task_Note>
    {
        public V_Task_NoteMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Tasknum, t.Fid, t.Fesid, t.Typeid, t.Tasktype, t.Editno, t.Createdate, t.Createtype, t.Onsiteid, t.Acceptdate, t.Enddate, t.Status, t.Bak, t.Onsite });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Tasknum)
                .IsRequired()
                .HasMaxLength(19);

            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fesid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Typeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Tasktype)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Editno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Createtype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Onsiteid)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Bak)
                .IsRequired()
                .HasMaxLength(1208);

            this.Property(t => t.Onsite)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("V_Task_Note");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Tasknum).HasColumnName("Tasknum");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Typeid).HasColumnName("Typeid");
            this.Property(t => t.Tasktype).HasColumnName("Tasktype");
            this.Property(t => t.Editno).HasColumnName("Editno");
            this.Property(t => t.Createdate).HasColumnName("Createdate");
            this.Property(t => t.Createtype).HasColumnName("Createtype");
            this.Property(t => t.Onsiteid).HasColumnName("Onsiteid");
            this.Property(t => t.Acceptdate).HasColumnName("Acceptdate");
            this.Property(t => t.Enddate).HasColumnName("Enddate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Bak).HasColumnName("Bak");
            this.Property(t => t.Onsite).HasColumnName("Onsite");
        }
    }
}
