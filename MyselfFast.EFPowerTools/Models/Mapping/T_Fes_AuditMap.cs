using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_AuditMap : EntityTypeConfiguration<T_Fes_Audit>
    {
        public T_Fes_AuditMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Source, t.Sourid, t.AuditNum, t.AuditType, t.Audit, t.AuditInfo, t.Operid, t.Oper, t.Opertime });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Source)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Sourid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Audit)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AuditInfo)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Operid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Oper)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Fes_Audit");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Source).HasColumnName("Source");
            this.Property(t => t.Sourid).HasColumnName("Sourid");
            this.Property(t => t.AuditNum).HasColumnName("AuditNum");
            this.Property(t => t.AuditType).HasColumnName("AuditType");
            this.Property(t => t.Audit).HasColumnName("Audit");
            this.Property(t => t.AuditInfo).HasColumnName("AuditInfo");
            this.Property(t => t.Operid).HasColumnName("Operid");
            this.Property(t => t.Oper).HasColumnName("Oper");
            this.Property(t => t.Opertime).HasColumnName("Opertime");
        }
    }
}
