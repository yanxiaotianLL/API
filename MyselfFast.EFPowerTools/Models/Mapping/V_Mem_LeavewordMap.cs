using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_Mem_LeavewordMap : EntityTypeConfiguration<V_Mem_Leaveword>
    {
        public V_Mem_LeavewordMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Danid, t.Title, t.Sort, t.Content1, t.Content2, t.Back1, t.Back2, t.Subtime1, t.Subtime2, t.Backtime1, t.Backtime2, t.Isback, t.Pic1, t.Pic2, t.Pic3, t.Pic4, t.Status, t.Backusername1, t.Backusername2, t.Xuhao, t.Hid, t.Readflag, t.Tel, t.Userkey, t.Yewubu, t.Cname, t.Sortview, t.Mark, t.Used, t.Fesid, t.Hno, t.Expr1, t.Ename, t.Usedname, t.Gno, t.CardId, t.Mobile });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Danid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Sort)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Content1)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.Content2)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.Back1)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.Back2)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.Isback)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Pic1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Pic2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Pic3)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Pic4)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Backusername1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Backusername2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Xuhao)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Hid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Readflag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Tel)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Userkey)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Yewubu)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Sortview)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mark)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Used)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fesid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Hno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Expr1)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Ename)
                .IsRequired()
                .HasMaxLength(800);

            this.Property(t => t.Usedname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Gno)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CardId)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("V_Mem_Leaveword");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Danid).HasColumnName("Danid");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.Content1).HasColumnName("Content1");
            this.Property(t => t.Content2).HasColumnName("Content2");
            this.Property(t => t.Back1).HasColumnName("Back1");
            this.Property(t => t.Back2).HasColumnName("Back2");
            this.Property(t => t.Subtime1).HasColumnName("Subtime1");
            this.Property(t => t.Subtime2).HasColumnName("Subtime2");
            this.Property(t => t.Backtime1).HasColumnName("Backtime1");
            this.Property(t => t.Backtime2).HasColumnName("Backtime2");
            this.Property(t => t.Isback).HasColumnName("Isback");
            this.Property(t => t.Pic1).HasColumnName("Pic1");
            this.Property(t => t.Pic2).HasColumnName("Pic2");
            this.Property(t => t.Pic3).HasColumnName("Pic3");
            this.Property(t => t.Pic4).HasColumnName("Pic4");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Backusername1).HasColumnName("Backusername1");
            this.Property(t => t.Backusername2).HasColumnName("Backusername2");
            this.Property(t => t.Xuhao).HasColumnName("Xuhao");
            this.Property(t => t.Hid).HasColumnName("Hid");
            this.Property(t => t.Readflag).HasColumnName("Readflag");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Userkey).HasColumnName("Userkey");
            this.Property(t => t.Yewubu).HasColumnName("Yewubu");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Sortview).HasColumnName("Sortview");
            this.Property(t => t.Mark).HasColumnName("Mark");
            this.Property(t => t.Used).HasColumnName("Used");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.Expr1).HasColumnName("Expr1");
            this.Property(t => t.Ename).HasColumnName("Ename");
            this.Property(t => t.Usedname).HasColumnName("Usedname");
            this.Property(t => t.Gno).HasColumnName("Gno");
            this.Property(t => t.CardId).HasColumnName("CardId");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
        }
    }
}
