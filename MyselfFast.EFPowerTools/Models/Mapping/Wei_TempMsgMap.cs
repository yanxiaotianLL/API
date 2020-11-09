using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Wei_TempMsgMap : EntityTypeConfiguration<Wei_TempMsg>
    {
        public Wei_TempMsgMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.SortName)
                .HasMaxLength(50);

            this.Property(t => t.Title)
                .HasMaxLength(150);

            this.Property(t => t.Key1)
                .HasMaxLength(150);

            this.Property(t => t.Key2)
                .HasMaxLength(150);

            this.Property(t => t.Key3)
                .HasMaxLength(150);

            this.Property(t => t.Key4)
                .HasMaxLength(150);

            this.Property(t => t.Key5)
                .HasMaxLength(150);

            this.Property(t => t.EndText)
                .HasMaxLength(950);

            this.Property(t => t.Note)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Wei_TempMsg");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SortName).HasColumnName("SortName");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Key1).HasColumnName("Key1");
            this.Property(t => t.Key2).HasColumnName("Key2");
            this.Property(t => t.Key3).HasColumnName("Key3");
            this.Property(t => t.Key4).HasColumnName("Key4");
            this.Property(t => t.Key5).HasColumnName("Key5");
            this.Property(t => t.EndText).HasColumnName("EndText");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.SetSendTime).HasColumnName("SetSendTime");
            this.Property(t => t.RealSendTime).HasColumnName("RealSendTime");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.OnlyNo).HasColumnName("OnlyNo");
        }
    }
}
