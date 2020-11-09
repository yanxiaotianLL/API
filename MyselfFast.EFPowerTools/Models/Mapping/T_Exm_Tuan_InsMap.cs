using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_Tuan_InsMap : EntityTypeConfiguration<T_Exm_Tuan_Ins>
    {
        public T_Exm_Tuan_InsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.IdCardNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Tel)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Comperny)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.HthCardNo)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.HthCardPassWord)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PersonId)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.PersonName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PersonidType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PersonSex)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.PersonMerry)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.PersonMobile)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.PersonComp)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_Exm_Tuan_Ins");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Timeid).HasColumnName("Timeid");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.IdCardType).HasColumnName("IdCardType");
            this.Property(t => t.IdCardNo).HasColumnName("IdCardNo");
            this.Property(t => t.BirthDay).HasColumnName("BirthDay");
            this.Property(t => t.IsMarry).HasColumnName("IsMarry");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Comperny).HasColumnName("Comperny");
            this.Property(t => t.PakegeId).HasColumnName("PakegeId");
            this.Property(t => t.HthCardNo).HasColumnName("HthCardNo");
            this.Property(t => t.HthCardPassWord).HasColumnName("HthCardPassWord");
            this.Property(t => t.PersonId).HasColumnName("PersonId");
            this.Property(t => t.PersonName).HasColumnName("PersonName");
            this.Property(t => t.PersonidType).HasColumnName("PersonidType");
            this.Property(t => t.PersonSex).HasColumnName("PersonSex");
            this.Property(t => t.PersonBirthday).HasColumnName("PersonBirthday");
            this.Property(t => t.PersonMerry).HasColumnName("PersonMerry");
            this.Property(t => t.PersonMobile).HasColumnName("PersonMobile");
            this.Property(t => t.PersonComp).HasColumnName("PersonComp");
        }
    }
}
