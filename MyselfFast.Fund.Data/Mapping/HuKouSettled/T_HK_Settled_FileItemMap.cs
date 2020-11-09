//
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using myselfFast.Fund.Core.Domain.HuKouSettled;

namespace myselfFast.Fund.Data.Mapping.HuKouSettled
{
    public class T_HK_Settled_FileItemMap : myselfFastEntityTypeConfiguration<T_HK_Settled_FileItem>
    {
        public T_HK_Settled_FileItemMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.MaritalStatus)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CensusRegister)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MigrationType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Aitem)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Bitem)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Citem)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_HK_Settled_FileItem");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.MaritalStatus).HasColumnName("MaritalStatus");
            this.Property(t => t.CensusRegister).HasColumnName("CensusRegister");
            this.Property(t => t.MigrationType).HasColumnName("MigrationType");
            this.Property(t => t.Aitem).HasColumnName("Aitem");
            this.Property(t => t.Bitem).HasColumnName("Bitem");
            this.Property(t => t.Citem).HasColumnName("Citem");
        }
    }
}
