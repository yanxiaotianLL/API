using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Scmsg_ChangebusMap : EntityTypeConfiguration<T_Scmsg_Changebus>
    {
        public T_Scmsg_ChangebusMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BusNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserNmae)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.UserKey)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserCard)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Depart)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ReMsg)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.CAUSE)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.changeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Sign)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ChangeItems)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_Scmsg_Changebus");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BusNumber).HasColumnName("BusNumber");
            this.Property(t => t.SortId).HasColumnName("SortId");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.UserNmae).HasColumnName("UserNmae");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.UserKey).HasColumnName("UserKey");
            this.Property(t => t.UserCard).HasColumnName("UserCard");
            this.Property(t => t.Depart).HasColumnName("Depart");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.ReMsg).HasColumnName("ReMsg");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.CAUSE).HasColumnName("CAUSE");
            this.Property(t => t.changeId).HasColumnName("changeId");
            this.Property(t => t.Cuiban).HasColumnName("Cuiban");
            this.Property(t => t.Sign).HasColumnName("Sign");
            this.Property(t => t.ChangeItems).HasColumnName("ChangeItems");
        }
    }
}
