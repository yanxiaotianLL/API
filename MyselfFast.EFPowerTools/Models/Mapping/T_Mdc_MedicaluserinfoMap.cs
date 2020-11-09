using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Mdc_MedicaluserinfoMap : EntityTypeConfiguration<T_Mdc_Medicaluserinfo>
    {
        public T_Mdc_MedicaluserinfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Utype)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Fname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Fesid)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Gbumen)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Cid)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.PeiCname)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.PeiCid)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.PeiSex)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.SCname)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.SCid)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.SSex)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Bankcount)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Obaoxiao)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Pbaoxiao)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Zbaoxiao)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Operuser)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.SX)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DX)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Mdc_Medicaluserinfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IsMedical).HasColumnName("IsMedical");
            this.Property(t => t.Utype).HasColumnName("Utype");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fname).HasColumnName("Fname");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Gbumen).HasColumnName("Gbumen");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Birthday).HasColumnName("Birthday");
            this.Property(t => t.PeiCname).HasColumnName("PeiCname");
            this.Property(t => t.PeiCid).HasColumnName("PeiCid");
            this.Property(t => t.PeiSex).HasColumnName("PeiSex");
            this.Property(t => t.PeiBirthday).HasColumnName("PeiBirthday");
            this.Property(t => t.SCname).HasColumnName("SCname");
            this.Property(t => t.SCid).HasColumnName("SCid");
            this.Property(t => t.SSex).HasColumnName("SSex");
            this.Property(t => t.SBirthday).HasColumnName("SBirthday");
            this.Property(t => t.Fulidate).HasColumnName("Fulidate");
            this.Property(t => t.KaihuhangId).HasColumnName("KaihuhangId");
            this.Property(t => t.Bxtype).HasColumnName("Bxtype");
            this.Property(t => t.Bankcount).HasColumnName("Bankcount");
            this.Property(t => t.Obaoxiao).HasColumnName("Obaoxiao");
            this.Property(t => t.Pbaoxiao).HasColumnName("Pbaoxiao");
            this.Property(t => t.Zbaoxiao).HasColumnName("Zbaoxiao");
            this.Property(t => t.Updatetime).HasColumnName("Updatetime");
            this.Property(t => t.Operuser).HasColumnName("Operuser");
            this.Property(t => t.SX).HasColumnName("SX");
            this.Property(t => t.DX).HasColumnName("DX");
        }
    }
}
