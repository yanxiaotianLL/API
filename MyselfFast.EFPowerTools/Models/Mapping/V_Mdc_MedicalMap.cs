using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_Mdc_MedicalMap : EntityTypeConfiguration<V_Mdc_Medical>
    {
        public V_Mdc_MedicalMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Fesid, t.OrderId, t.Hospital, t.Jzrq, t.Jbmc, t.Sjzs, t.Sbje, t.Djzs, t.FyLx, t.Znjzdd, t.Mtype, t.Jsuan, t.Istjsb, t.Idate, t.PeiCname, t.PeiCid, t.PeiSex, t.PeiBirthday, t.SCname, t.SCid, t.SSex, t.SBirthday, t.Mstatus, t.Psbak, t.Isdel, t.Hno, t.Cid, t.Fname, t.IsMedical, t.Pbaoxiao, t.Zbaoxiao, t.Bxtype, t.Cname, t.Fid });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Fesid)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.OrderId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Hospital)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Jbmc)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Sjzs)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Sbje)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Djzs)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FyLx)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Znjzdd)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Mtype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Jsuan)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Istjsb)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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
                .HasMaxLength(20);

            this.Property(t => t.SSex)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Mstatus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Psbak)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Isdel)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Hno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Cid)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Fname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.IsMedical)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Pbaoxiao)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Zbaoxiao)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Bxtype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("V_Mdc_Medical");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.Hospital).HasColumnName("Hospital");
            this.Property(t => t.Jzrq).HasColumnName("Jzrq");
            this.Property(t => t.Jbmc).HasColumnName("Jbmc");
            this.Property(t => t.Sjzs).HasColumnName("Sjzs");
            this.Property(t => t.Sbje).HasColumnName("Sbje");
            this.Property(t => t.Djzs).HasColumnName("Djzs");
            this.Property(t => t.FyLx).HasColumnName("FyLx");
            this.Property(t => t.Znjzdd).HasColumnName("Znjzdd");
            this.Property(t => t.Mtype).HasColumnName("Mtype");
            this.Property(t => t.Jsuan).HasColumnName("Jsuan");
            this.Property(t => t.Istjsb).HasColumnName("Istjsb");
            this.Property(t => t.Idate).HasColumnName("Idate");
            this.Property(t => t.PeiCname).HasColumnName("PeiCname");
            this.Property(t => t.PeiCid).HasColumnName("PeiCid");
            this.Property(t => t.PeiSex).HasColumnName("PeiSex");
            this.Property(t => t.PeiBirthday).HasColumnName("PeiBirthday");
            this.Property(t => t.SCname).HasColumnName("SCname");
            this.Property(t => t.SCid).HasColumnName("SCid");
            this.Property(t => t.SSex).HasColumnName("SSex");
            this.Property(t => t.SBirthday).HasColumnName("SBirthday");
            this.Property(t => t.Mstatus).HasColumnName("Mstatus");
            this.Property(t => t.Psbak).HasColumnName("Psbak");
            this.Property(t => t.Isdel).HasColumnName("Isdel");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Fname).HasColumnName("Fname");
            this.Property(t => t.IsMedical).HasColumnName("IsMedical");
            this.Property(t => t.Pbaoxiao).HasColumnName("Pbaoxiao");
            this.Property(t => t.Zbaoxiao).HasColumnName("Zbaoxiao");
            this.Property(t => t.Bxtype).HasColumnName("Bxtype");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Fid).HasColumnName("Fid");
        }
    }
}
