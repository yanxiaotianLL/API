using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class HV_TASKTAILMap : EntityTypeConfiguration<HV_TASKTAIL>
    {
        public HV_TASKTAILMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Taskid, t.Mno, t.Editno, t.Tasktypeid, t.Tasktype, t.Typeid, t.Typename, t.Status, t.Mark, t.Oper, t.Createtime, t.Script, t.Cname, t.Fid, t.ltd, t.Hno, t.Cid, t.Bak });

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

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(330);

            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ltd)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.Hno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Cid)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Bak)
                .IsRequired()
                .HasMaxLength(1208);

            // Table & Column Mappings
            this.ToTable("HV_TASKTAIL");
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
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.ltd).HasColumnName("ltd");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Bak).HasColumnName("Bak");
        }
    }
}
