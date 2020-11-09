using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Int_TokenuserMap : EntityTypeConfiguration<T_Int_Tokenuser>
    {
        public T_Int_TokenuserMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Tokenwords)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Newtokenwords)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Int_Tokenuser");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.Tokenwords).HasColumnName("Tokenwords");
            this.Property(t => t.Newtokenwords).HasColumnName("Newtokenwords");
        }
    }
}
