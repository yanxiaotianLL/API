using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Task_Note_TailMap : EntityTypeConfiguration<T_Task_Note_Tail>
    {
        public T_Task_Note_TailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Taskid, t.Editno, t.Typeid });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Taskid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Editno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Typeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Typename)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Mark)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("T_Task_Note_Tail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Taskid).HasColumnName("Taskid");
            this.Property(t => t.Editno).HasColumnName("Editno");
            this.Property(t => t.Typeid).HasColumnName("Typeid");
            this.Property(t => t.Typename).HasColumnName("Typename");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Mark).HasColumnName("Mark");
            this.Property(t => t.Oper).HasColumnName("Oper");
            this.Property(t => t.Createtime).HasColumnName("Createtime");
        }
    }
}
