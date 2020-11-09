using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_User_For_DeletedMap : EntityTypeConfiguration<T_Fes_User_For_Deleted>
    {
        public T_Fes_User_For_DeletedMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fname)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ename)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Gno)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.CardId)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_Fes_User_For_Deleted");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fname).HasColumnName("Fname");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Ename).HasColumnName("Ename");
            this.Property(t => t.Gno).HasColumnName("Gno");
            this.Property(t => t.CardType).HasColumnName("CardType");
            this.Property(t => t.CardId).HasColumnName("CardId");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Verify).HasColumnName("Verify");
            this.Property(t => t.SafeVerify).HasColumnName("SafeVerify");
            this.Property(t => t.Isdeleted).HasColumnName("Isdeleted");
            this.Property(t => t.DeleteTime).HasColumnName("DeleteTime");
        }
    }
}
