using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_TASK_TAILMap : EntityTypeConfiguration<V_TASK_TAIL>
    {
        public V_TASK_TAILMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Taskid, t.Mno, t.Editno, t.Tasktypeid, t.Tasktype, t.Typeid, t.Typename, t.Status, t.Mark, t.Oper, t.Createtime, t.Script, t.Fid, t.Fesid, t.Bak });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Taskid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Mno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Editno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Tasktypeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Tasktype)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Typeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Typename)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Mark)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Oper)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Script)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.RealName)
                .HasMaxLength(128);

            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fesid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Bak)
                .IsRequired()
                .HasMaxLength(1208);

            // Table & Column Mappings
            this.ToTable("V_TASK_TAIL");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Taskid).HasColumnName("Taskid");
            this.Property(t => t.Mno).HasColumnName("Mno");
            this.Property(t => t.Editno).HasColumnName("Editno");
            this.Property(t => t.Tasktypeid).HasColumnName("Tasktypeid");
            this.Property(t => t.Tasktype).HasColumnName("Tasktype");
            this.Property(t => t.Typeid).HasColumnName("Typeid");
            this.Property(t => t.Typename).HasColumnName("Typename");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Mark).HasColumnName("Mark");
            this.Property(t => t.Oper).HasColumnName("Oper");
            this.Property(t => t.Createtime).HasColumnName("Createtime");
            this.Property(t => t.Script).HasColumnName("Script");
            this.Property(t => t.ONSITE).HasColumnName("ONSITE");
            this.Property(t => t.RealName).HasColumnName("RealName");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Bak).HasColumnName("Bak");
        }
    }
}
