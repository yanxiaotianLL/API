using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_User201608021703Map : EntityTypeConfiguration<T_Exm_User201608021703>
    {
        public T_Exm_User201608021703Map()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.UserId, t.UserName, t.CheckNo, t.CheckcardId, t.PassWord, t.PersonId, t.PersonName, t.PersonidType, t.PersonSex, t.PersonBirthday, t.PersonMerry, t.PersonMobile, t.PersonComp, t.PackageId, t.PackageName, t.Year, t.JigouId, t.ChooseJigou, t.ContentMsg, t.PartId, t.ParentName, t.CityId, t.ChooseCity, t.ReportAuth, t.Adminuid, t.AdminName, t.LastDatetime, t.HistoryId, t.Link, t.ProjectId, t.Fid, t.Education, t.State, t.SubTime, t.CheckDate, t.WriteDate, t.BackReportTime, t.Scales, t.IsIntervention, t.CheckType, t.OtherOrderNum, t.OtherCardNum, t.IsCustom, t.CanReason, t.DataFrom, t.IsExport_Other, t.IsOver_Other, t.EditerId, t.EditerName, t.EditTime, t.IsBackReport, t.Isdelete, t.IsUserSelf });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.CheckNo)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CheckcardId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PassWord)
                .IsRequired()
                .HasMaxLength(50);

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

            this.Property(t => t.PackageId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PackageName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.JigouId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ChooseJigou)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ContentMsg)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.PartId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ParentName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CityId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ChooseCity)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ReportAuth)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Adminuid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AdminName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.HistoryId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Link)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ProjectId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Education)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.State)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Scales)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CheckType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OtherOrderNum)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.OtherCardNum)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IsCustom)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CanReason)
                .IsRequired();

            this.Property(t => t.DataFrom)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EditerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EditerName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Exm_User201608021703");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.CheckNo).HasColumnName("CheckNo");
            this.Property(t => t.CheckcardId).HasColumnName("CheckcardId");
            this.Property(t => t.PassWord).HasColumnName("PassWord");
            this.Property(t => t.PersonId).HasColumnName("PersonId");
            this.Property(t => t.PersonName).HasColumnName("PersonName");
            this.Property(t => t.PersonidType).HasColumnName("PersonidType");
            this.Property(t => t.PersonSex).HasColumnName("PersonSex");
            this.Property(t => t.PersonBirthday).HasColumnName("PersonBirthday");
            this.Property(t => t.PersonMerry).HasColumnName("PersonMerry");
            this.Property(t => t.PersonMobile).HasColumnName("PersonMobile");
            this.Property(t => t.PersonComp).HasColumnName("PersonComp");
            this.Property(t => t.PackageId).HasColumnName("PackageId");
            this.Property(t => t.PackageName).HasColumnName("PackageName");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.JigouId).HasColumnName("JigouId");
            this.Property(t => t.ChooseJigou).HasColumnName("ChooseJigou");
            this.Property(t => t.ContentMsg).HasColumnName("ContentMsg");
            this.Property(t => t.PartId).HasColumnName("PartId");
            this.Property(t => t.ParentName).HasColumnName("ParentName");
            this.Property(t => t.CityId).HasColumnName("CityId");
            this.Property(t => t.ChooseCity).HasColumnName("ChooseCity");
            this.Property(t => t.ReportAuth).HasColumnName("ReportAuth");
            this.Property(t => t.Adminuid).HasColumnName("Adminuid");
            this.Property(t => t.AdminName).HasColumnName("AdminName");
            this.Property(t => t.LastDatetime).HasColumnName("LastDatetime");
            this.Property(t => t.HistoryId).HasColumnName("HistoryId");
            this.Property(t => t.Link).HasColumnName("Link");
            this.Property(t => t.ProjectId).HasColumnName("ProjectId");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Education).HasColumnName("Education");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.SubTime).HasColumnName("SubTime");
            this.Property(t => t.CheckDate).HasColumnName("CheckDate");
            this.Property(t => t.WriteDate).HasColumnName("WriteDate");
            this.Property(t => t.BackReportTime).HasColumnName("BackReportTime");
            this.Property(t => t.Scales).HasColumnName("Scales");
            this.Property(t => t.IsIntervention).HasColumnName("IsIntervention");
            this.Property(t => t.CheckType).HasColumnName("CheckType");
            this.Property(t => t.OtherOrderNum).HasColumnName("OtherOrderNum");
            this.Property(t => t.OtherCardNum).HasColumnName("OtherCardNum");
            this.Property(t => t.IsCustom).HasColumnName("IsCustom");
            this.Property(t => t.CanReason).HasColumnName("CanReason");
            this.Property(t => t.DataFrom).HasColumnName("DataFrom");
            this.Property(t => t.IsExport_Other).HasColumnName("IsExport_Other");
            this.Property(t => t.IsOver_Other).HasColumnName("IsOver_Other");
            this.Property(t => t.EditerId).HasColumnName("EditerId");
            this.Property(t => t.EditerName).HasColumnName("EditerName");
            this.Property(t => t.EditTime).HasColumnName("EditTime");
            this.Property(t => t.IsBackReport).HasColumnName("IsBackReport");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
            this.Property(t => t.IsUserSelf).HasColumnName("IsUserSelf");
        }
    }
}
