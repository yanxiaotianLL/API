using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_MicrAct_CardMap : EntityTypeConfiguration<T_MicrAct_Card>
    {
        public T_MicrAct_CardMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CardNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CreateUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UpdateUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IDCard)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_MicrAct_Card");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ActiveID).HasColumnName("ActiveID");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.BeginTime).HasColumnName("BeginTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.ActTime).HasColumnName("ActTime");
            this.Property(t => t.ActState).HasColumnName("ActState");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.UpdateUser).HasColumnName("UpdateUser");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.IDCard).HasColumnName("IDCard");
            this.Property(t => t.FesID).HasColumnName("FesID");
        }
    }
}
