using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Mdc_MedicalMap : EntityTypeConfiguration<T_Mdc_Medical>
    {
        public T_Mdc_MedicalMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
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

            this.Property(t => t.Znjzdd)
                .IsRequired()
                .HasMaxLength(256);

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

            this.Property(t => t.Psbak)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_Mdc_Medical");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
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
        }
    }
}
