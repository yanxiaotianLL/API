using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Onl_IFInfoMap : EntityTypeConfiguration<T_Onl_IFInfo>
    {
        public T_Onl_IFInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserSex)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserNation)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserCardNum)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CompName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserType)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Onl_IFInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Danid).HasColumnName("Danid");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.UserSex).HasColumnName("UserSex");
            this.Property(t => t.UserBirth).HasColumnName("UserBirth");
            this.Property(t => t.UserNation).HasColumnName("UserNation");
            this.Property(t => t.UserCardNum).HasColumnName("UserCardNum");
            this.Property(t => t.WorkTimes).HasColumnName("WorkTimes");
            this.Property(t => t.CompName).HasColumnName("CompName");
            this.Property(t => t.BeginDate).HasColumnName("BeginDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.EnjoyHouse).HasColumnName("EnjoyHouse");
            this.Property(t => t.EnjoyWarm).HasColumnName("EnjoyWarm");
            this.Property(t => t.UserType).HasColumnName("UserType");
        }
    }
}
