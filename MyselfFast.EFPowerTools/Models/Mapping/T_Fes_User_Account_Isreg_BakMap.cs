using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_User_Account_Isreg_BakMap : EntityTypeConfiguration<T_Fes_User_Account_Isreg_Bak>
    {
        public T_Fes_User_Account_Isreg_BakMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Fesid, t.Uno, t.Fid, t.Fno, t.FenType, t.FenTypeName, t.AccountName, t.FenTag, t.FenStans, t.Spread, t.Fenable, t.Fenall, t.Fencur, t.Fenlock, t.Fenstate, t.Fenlimit, t.Bak, t.RecycleFen });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fesid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Uno)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fno)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FenType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FenTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AccountName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FenTag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FenStans)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Fenall)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fencur)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fenlock)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fenstate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Bak)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.RecycleFen)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_Fes_User_Account_Isreg_Bak");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Uno).HasColumnName("Uno");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fno).HasColumnName("Fno");
            this.Property(t => t.FenType).HasColumnName("FenType");
            this.Property(t => t.FenTypeName).HasColumnName("FenTypeName");
            this.Property(t => t.AccountName).HasColumnName("AccountName");
            this.Property(t => t.FenTag).HasColumnName("FenTag");
            this.Property(t => t.FenStans).HasColumnName("FenStans");
            this.Property(t => t.Spread).HasColumnName("Spread");
            this.Property(t => t.Fenable).HasColumnName("Fenable");
            this.Property(t => t.Fenall).HasColumnName("Fenall");
            this.Property(t => t.Fencur).HasColumnName("Fencur");
            this.Property(t => t.Fenlock).HasColumnName("Fenlock");
            this.Property(t => t.Fenstate).HasColumnName("Fenstate");
            this.Property(t => t.Fenlimit).HasColumnName("Fenlimit");
            this.Property(t => t.Bak).HasColumnName("Bak");
            this.Property(t => t.RecycleFen).HasColumnName("RecycleFen");
        }
    }
}
