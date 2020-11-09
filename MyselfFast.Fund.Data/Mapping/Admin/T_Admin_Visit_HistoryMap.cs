using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using myselfFast.Fund.Core.Domain.Admin;

namespace myselfFast.Fund.Data.Mapping.Admin
{
    public class T_Admin_Visit_HistoryMap : myselfFastEntityTypeConfiguration<T_Admin_Visit_History>
    {
        public T_Admin_Visit_HistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            //this.Property(t => t.Id)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ip)
                .HasMaxLength(50);

            

            this.Property(t => t.RawUrl)
                .HasMaxLength(1000);

            this.Property(t => t.UrlReferrer)
                .HasMaxLength(1000);

            this.Property(t => t.UserAgent)
                .HasMaxLength(200);

            this.Property(t => t.UserName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Admin_Visit_History");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Ip).HasColumnName("Ip");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            //this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.RawUrl).HasColumnName("RawUrl");
            this.Property(t => t.UrlReferrer).HasColumnName("UrlReferrer");
            this.Property(t => t.UserAgent).HasColumnName("UserAgent");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Controller).HasColumnName("Controller");
            this.Property(t => t.Action).HasColumnName("Action");
        }
    }
}

