//
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using myselfFast.Fund.Core.Domain.Hukou;

namespace myselfFast.Fund.Data.Mapping.Hukou
{
    public class T_HK_Hukou_LendMap : myselfFastEntityTypeConfiguration<T_HK_Hukou_Lend>
    {
        public T_HK_Hukou_LendMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Uniqueno)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Usage)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Otherdesc)
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

            this.Property(t => t.Remark)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.StateName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HuKouPateern)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Trackingnumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Trackingcompany)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cause)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_HK_Hukou_Lend");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Taskid).HasColumnName("Taskid");
            this.Property(t => t.Uniqueno).HasColumnName("Uniqueno");
            this.Property(t => t.Addressid).HasColumnName("Addressid");
            this.Property(t => t.Usage).HasColumnName("Usage");
            this.Property(t => t.Otherdesc).HasColumnName("Otherdesc");
            this.Property(t => t.Copydoc).HasColumnName("Copydoc");
            this.Property(t => t.Originaldoc).HasColumnName("Originaldoc");
            this.Property(t => t.Firstpage).HasColumnName("Firstpage");
            this.Property(t => t.Photo1).HasColumnName("Photo1");
            this.Property(t => t.Photo2).HasColumnName("Photo2");
            this.Property(t => t.Photo3).HasColumnName("Photo3");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Optime).HasColumnName("Optime");
            this.Property(t => t.Committime).HasColumnName("Committime");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.StateName).HasColumnName("StateName");
            this.Property(t => t.Isback).HasColumnName("Isback");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
            this.Property(t => t.Flag).HasColumnName("Flag");
            this.Property(t => t.Frequency).HasColumnName("Frequency");
            this.Property(t => t.HuKouPateern).HasColumnName("HuKouPateern");
            this.Property(t => t.Trackingnumber).HasColumnName("Trackingnumber");
            this.Property(t => t.EndRenewaltime).HasColumnName("EndRenewaltime");
            this.Property(t => t.Trackingcompany).HasColumnName("Trackingcompany");
            this.Property(t => t.Cause).HasColumnName("Cause");
            this.Property(t => t.Firstcopy).HasColumnName("Firstcopy");
            this.Property(t => t.FrontIDCard).HasColumnName("FrontIDCard");
            this.Property(t => t.ReverseIDCard).HasColumnName("ReverseIDCard");
            this.Property(t => t.NewHKfirstPage).HasColumnName("NewHKfirstPage");
            this.Property(t => t.NewHKSelfPage).HasColumnName("NewHKSelfPage");
        }
    }
}
