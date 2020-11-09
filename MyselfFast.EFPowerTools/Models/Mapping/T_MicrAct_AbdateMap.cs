using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_MicrAct_AbdateMap : EntityTypeConfiguration<T_MicrAct_Abdate>
    {
        public T_MicrAct_AbdateMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CreateUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UpdateUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_MicrAct_Abdate");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ActiveID).HasColumnName("ActiveID");
            this.Property(t => t.BaoDate).HasColumnName("BaoDate");
            this.Property(t => t.Nums).HasColumnName("Nums");
            this.Property(t => t.AdultNums).HasColumnName("AdultNums");
            this.Property(t => t.ChildNums).HasColumnName("ChildNums");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.SignCountNums).HasColumnName("SignCountNums");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.UpdateUser).HasColumnName("UpdateUser");
            this.Property(t => t.ResNums).HasColumnName("ResNums");
            this.Property(t => t.TotalNums).HasColumnName("TotalNums");
            this.Property(t => t.MaleNums).HasColumnName("MaleNums");
            this.Property(t => t.FemaleNums).HasColumnName("FemaleNums");
        }
    }
}
