using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.Collect.Core.Test.Models.Mapping
{
    public class T_Admin_DepartMap : EntityTypeConfiguration<T_Admin_Depart>
    {
        public T_Admin_DepartMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.DepartName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DepartDescription)
                .HasMaxLength(500);

            this.Property(t => t.CreateAdmin)
                .HasMaxLength(20);

            this.Property(t => t.UpdateAdmin)
                .HasMaxLength(20);

            this.Property(t => t.DepartLeader)
                .HasMaxLength(50);

            this.Property(t => t.LeaderEmail)
                .HasMaxLength(20);

            this.Property(t => t.DepartCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Admin_Depart");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.DepartName).HasColumnName("DepartName");
            this.Property(t => t.DepartDescription).HasColumnName("DepartDescription");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.CreateAdmin).HasColumnName("CreateAdmin");
            this.Property(t => t.UpdateAdmin).HasColumnName("UpdateAdmin");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.DepartLeader).HasColumnName("DepartLeader");
            this.Property(t => t.LeaderEmail).HasColumnName("LeaderEmail");
            this.Property(t => t.SortValue).HasColumnName("SortValue");
            this.Property(t => t.DepartCode).HasColumnName("DepartCode");
            this.Property(t => t.IsLeaf).HasColumnName("IsLeaf");
        }
    }
}
