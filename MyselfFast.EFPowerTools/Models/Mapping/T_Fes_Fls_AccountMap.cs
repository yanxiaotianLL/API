using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_Fls_AccountMap : EntityTypeConfiguration<T_Fes_Fls_Account>
    {
        public T_Fes_Fls_AccountMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Fno)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.AccountName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FenTypeName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FenStans)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Fes_Fls_Account");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fno).HasColumnName("Fno");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.FenType).HasColumnName("FenType");
            this.Property(t => t.AccountName).HasColumnName("AccountName");
            this.Property(t => t.FenTypeName).HasColumnName("FenTypeName");
            this.Property(t => t.FenTag).HasColumnName("FenTag");
            this.Property(t => t.FenStans).HasColumnName("FenStans");
            this.Property(t => t.Spread).HasColumnName("Spread");
            this.Property(t => t.Fenable).HasColumnName("Fenable");
            this.Property(t => t.Fenall).HasColumnName("Fenall");
            this.Property(t => t.Fencur).HasColumnName("Fencur");
            this.Property(t => t.Fenlock).HasColumnName("Fenlock");
            this.Property(t => t.Fenlimit).HasColumnName("Fenlimit");
            this.Property(t => t.RecycleFen).HasColumnName("RecycleFen");
            this.Property(t => t.Fprice).HasColumnName("Fprice");
        }
    }
}
