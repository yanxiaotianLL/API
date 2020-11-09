using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_AskCauseMap : EntityTypeConfiguration<T_Gds_AskCause>
    {
        public T_Gds_AskCauseMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Hid, t.Cause, t.Ctype, t.State, t.Gendate, t.DownFromGysDate, t.DownFromFescoDate, t.Oper });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Hid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Cause)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Ctype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.State)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Oper)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Gds_AskCause");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Hid).HasColumnName("Hid");
            this.Property(t => t.Cause).HasColumnName("Cause");
            this.Property(t => t.Ctype).HasColumnName("Ctype");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Gendate).HasColumnName("Gendate");
            this.Property(t => t.DownFromGysDate).HasColumnName("DownFromGysDate");
            this.Property(t => t.DownFromFescoDate).HasColumnName("DownFromFescoDate");
            this.Property(t => t.Oper).HasColumnName("Oper");
        }
    }
}
