using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Act_AbdateMap : EntityTypeConfiguration<T_Act_Abdate>
    {
        public T_Act_AbdateMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Activeid, t.Baodate, t.Nums, t.Memo, t.Isdelete, t.SignCountNums });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Activeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nums)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.SignCountNums)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_Act_Abdate");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Activeid).HasColumnName("Activeid");
            this.Property(t => t.Baodate).HasColumnName("Baodate");
            this.Property(t => t.Nums).HasColumnName("Nums");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
            this.Property(t => t.SignCountNums).HasColumnName("SignCountNums");
        }
    }
}
