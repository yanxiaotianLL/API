//
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using myselfFast.Fund.Core.Domain.HuKouSettled;

namespace myselfFast.Fund.Data.Mapping.HuKouSettled
{
    public class T_HK_Settled_InfoMap : myselfFastEntityTypeConfiguration<T_HK_Settled_Info>
    {
        public T_HK_Settled_InfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.OrderId)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.RecordState)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.MaritalStatus)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.CensusRegister)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.MigrationType)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.UsedName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Blood)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ContactPhone)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.EmerContactName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EmerContactPhone)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.District)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.DadName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.MumName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CpName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.AdminName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Opinion)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Reason)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.FileItem)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ExpressNum)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ExpressName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_HK_Settled_Info");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.RecordState).HasColumnName("RecordState");
            this.Property(t => t.MaritalStatus).HasColumnName("MaritalStatus");
            this.Property(t => t.CensusRegister).HasColumnName("CensusRegister");
            this.Property(t => t.MigrationType).HasColumnName("MigrationType");
            this.Property(t => t.UsedName).HasColumnName("UsedName");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.Blood).HasColumnName("Blood");
            this.Property(t => t.ContactPhone).HasColumnName("ContactPhone");
            this.Property(t => t.EmerContactName).HasColumnName("EmerContactName");
            this.Property(t => t.EmerContactPhone).HasColumnName("EmerContactPhone");
            this.Property(t => t.District).HasColumnName("District");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.DadName).HasColumnName("DadName");
            this.Property(t => t.MumName).HasColumnName("MumName");
            this.Property(t => t.CpName).HasColumnName("CpName");
            this.Property(t => t.MigrationStart).HasColumnName("MigrationStart");
            this.Property(t => t.MigrationEnd).HasColumnName("MigrationEnd");
            this.Property(t => t.ChekcDate).HasColumnName("ChekcDate");
            this.Property(t => t.ApplyDate).HasColumnName("ApplyDate");
            this.Property(t => t.SubmitDate).HasColumnName("SubmitDate");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.IsCurrent).HasColumnName("IsCurrent");
            this.Property(t => t.AdminTime).HasColumnName("AdminTime");
            this.Property(t => t.AdminId).HasColumnName("AdminId");
            this.Property(t => t.AdminName).HasColumnName("AdminName");
            this.Property(t => t.IsAgain).HasColumnName("IsAgain");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Opinion).HasColumnName("Opinion");
            this.Property(t => t.Reason).HasColumnName("Reason");
            this.Property(t => t.FileItem).HasColumnName("FileItem");
            this.Property(t => t.OperateTime).HasColumnName("OperateTime");
            this.Property(t => t.Pid).HasColumnName("Pid");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.ExpressNum).HasColumnName("ExpressNum");
            this.Property(t => t.ExpressName).HasColumnName("ExpressName");
        }
    }
}
