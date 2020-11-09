using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_HK_Hokou_TransferMap : EntityTypeConfiguration<T_HK_Hokou_Transfer>
    {
        public T_HK_Hokou_TransferMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Uniqueno)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Billtitle)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Photo1)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Photo2)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Photo3)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Photo4)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Remark)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.StateName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Native)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Phone)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.NewCompany)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.EmigrationReason)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.EmigrationAddress)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CancelReason)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ToCountry)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.MaritalStatus)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CardId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Usage)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Username)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_HK_Hokou_Transfer");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Taskid).HasColumnName("Taskid");
            this.Property(t => t.Uniqueno).HasColumnName("Uniqueno");
            this.Property(t => t.Addressid).HasColumnName("Addressid");
            this.Property(t => t.Transtype).HasColumnName("Transtype");
            this.Property(t => t.Transtableid).HasColumnName("Transtableid");
            this.Property(t => t.Billtitle).HasColumnName("Billtitle");
            this.Property(t => t.Photo1).HasColumnName("Photo1");
            this.Property(t => t.Photo2).HasColumnName("Photo2");
            this.Property(t => t.Photo3).HasColumnName("Photo3");
            this.Property(t => t.Photo4).HasColumnName("Photo4");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Optime).HasColumnName("Optime");
            this.Property(t => t.Committime).HasColumnName("Committime");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.StateName).HasColumnName("StateName");
            this.Property(t => t.Isback).HasColumnName("Isback");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
            this.Property(t => t.Flag).HasColumnName("Flag");
            this.Property(t => t.Native).HasColumnName("Native");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.NewCompany).HasColumnName("NewCompany");
            this.Property(t => t.EmigrationReason).HasColumnName("EmigrationReason");
            this.Property(t => t.EmigrationAddress).HasColumnName("EmigrationAddress");
            this.Property(t => t.CancelReason).HasColumnName("CancelReason");
            this.Property(t => t.ToCountry).HasColumnName("ToCountry");
            this.Property(t => t.Inhometime).HasColumnName("Inhometime");
            this.Property(t => t.Emigrationtime).HasColumnName("Emigrationtime");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.MaritalStatus).HasColumnName("MaritalStatus");
            this.Property(t => t.CardId).HasColumnName("CardId");
            this.Property(t => t.Birthday).HasColumnName("Birthday");
            this.Property(t => t.Usage).HasColumnName("Usage");
            this.Property(t => t.Username).HasColumnName("Username");
        }
    }
}
