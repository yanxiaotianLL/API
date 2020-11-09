using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Act_ActiveMap : EntityTypeConfiguration<T_Act_Active>
    {
        public T_Act_ActiveMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Introduction)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.Content)
                .IsRequired();

            this.Property(t => t.Pic)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Bigpic)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Activetime)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Accountno)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_Act_Active");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.fid).HasColumnName("fid");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Introduction).HasColumnName("Introduction");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Pubtime).HasColumnName("Pubtime");
            this.Property(t => t.Pic).HasColumnName("Pic");
            this.Property(t => t.Bigpic).HasColumnName("Bigpic");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Foruse).HasColumnName("Foruse");
            this.Property(t => t.Ischarge).HasColumnName("Ischarge");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Regnum).HasColumnName("Regnum");
            this.Property(t => t.Val).HasColumnName("Val");
            this.Property(t => t.Regbuttonshow).HasColumnName("Regbuttonshow");
            this.Property(t => t.Activetime).HasColumnName("Activetime");
            this.Property(t => t.Ontop).HasColumnName("Ontop");
            this.Property(t => t.Begindate).HasColumnName("Begindate");
            this.Property(t => t.Enddate).HasColumnName("Enddate");
            this.Property(t => t.Sendtype).HasColumnName("Sendtype");
            this.Property(t => t.Isshowinlist).HasColumnName("Isshowinlist");
            this.Property(t => t.Accountno).HasColumnName("Accountno");
            this.Property(t => t.Clubid).HasColumnName("Clubid");
            this.Property(t => t.Isemp).HasColumnName("Isemp");
            this.Property(t => t.Iswenti).HasColumnName("Iswenti");
            this.Property(t => t.Isxianchang).HasColumnName("Isxianchang");
            this.Property(t => t.Pubtype).HasColumnName("Pubtype");
            this.Property(t => t.Limitwenti).HasColumnName("Limitwenti");
            this.Property(t => t.Isverify).HasColumnName("Isverify");
            this.Property(t => t.IsIndexDisplay).HasColumnName("IsIndexDisplay");
            this.Property(t => t.Personnum).HasColumnName("Personnum");
            this.Property(t => t.surplusNum).HasColumnName("surplusNum");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
        }
    }
}
