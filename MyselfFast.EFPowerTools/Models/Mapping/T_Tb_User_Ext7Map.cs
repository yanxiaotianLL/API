using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Tb_User_Ext7Map : EntityTypeConfiguration<T_Tb_User_Ext7>
    {
        public T_Tb_User_Ext7Map()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.MaternityLeave)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("T_Tb_User_Ext7");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Uid).HasColumnName("Uid");
            this.Property(t => t.MaternityLeave).HasColumnName("MaternityLeave");
            this.Property(t => t.PersonalState).HasColumnName("PersonalState");
            this.Property(t => t.RecordState).HasColumnName("RecordState");
            this.Property(t => t.MemberState).HasColumnName("MemberState");
            this.Property(t => t.SocialState).HasColumnName("SocialState");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
        }
    }
}
