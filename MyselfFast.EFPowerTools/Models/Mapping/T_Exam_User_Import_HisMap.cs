using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exam_User_Import_HisMap : EntityTypeConfiguration<T_Exam_User_Import_His>
    {
        public T_Exam_User_Import_HisMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Gno)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CardName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CardNo)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("T_Exam_User_Import_His");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Gno).HasColumnName("Gno");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.CityId).HasColumnName("CityId");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.CardType).HasColumnName("CardType");
            this.Property(t => t.CardName).HasColumnName("CardName");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.ImportTime).HasColumnName("ImportTime");
            this.Property(t => t.IsInc).HasColumnName("IsInc");
            this.Property(t => t.BakTime).HasColumnName("BakTime");
        }
    }
}
