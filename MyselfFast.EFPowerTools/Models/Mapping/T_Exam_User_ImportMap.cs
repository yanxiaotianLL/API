using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exam_User_ImportMap : EntityTypeConfiguration<T_Exam_User_Import>
    {
        public T_Exam_User_ImportMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Gno)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ename)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CardName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CardNo)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ChkText)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Exam_User_Import");
            this.Property(t => t.ProjectId).HasColumnName("ProjectId");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Gno).HasColumnName("Gno");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Ename).HasColumnName("Ename");
            this.Property(t => t.CityId).HasColumnName("CityId");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.CardType).HasColumnName("CardType");
            this.Property(t => t.CardName).HasColumnName("CardName");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.ImportTime).HasColumnName("ImportTime");
            this.Property(t => t.IsInc).HasColumnName("IsInc");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ChkState).HasColumnName("ChkState");
            this.Property(t => t.Chktype).HasColumnName("Chktype");
            this.Property(t => t.ChkText).HasColumnName("ChkText");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
