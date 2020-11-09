using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Tot_User_Fen_MonthMap : EntityTypeConfiguration<T_Tot_User_Fen_Month>
    {
        public T_Tot_User_Fen_MonthMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_Tot_User_Fen_Month");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.NY).HasColumnName("NY");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Fentype).HasColumnName("Fentype");
            this.Property(t => t.FenLost).HasColumnName("FenLost");
            this.Property(t => t.FenAdded).HasColumnName("FenAdded");
            this.Property(t => t.FenUsed).HasColumnName("FenUsed");
            this.Property(t => t.FenBacked).HasColumnName("FenBacked");
            this.Property(t => t.FenReturned).HasColumnName("FenReturned");
            this.Property(t => t.FenTrsIn).HasColumnName("FenTrsIn");
            this.Property(t => t.FenTrsOut).HasColumnName("FenTrsOut");
        }
    }
}
