using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Act_ReginputMap : EntityTypeConfiguration<T_Act_Reginput>
    {
        public T_Act_ReginputMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Activeid, t.Input1, t.Input2, t.Input3, t.Input4, t.Input5, t.Input6, t.Input7, t.Input8, t.Input9, t.Input10, t.Input11, t.Input12, t.Input13, t.Input14, t.Input15, t.Input16, t.Input17, t.Input18, t.Input19, t.Input20, t.Mst1, t.Mst2, t.Mst3, t.Mst4, t.Mst5, t.Mst6, t.Mst7, t.Mst8, t.Mst9, t.Mst10, t.Mst11, t.Mst12, t.Mst13, t.Mst14, t.Mst15, t.Mst16, t.Mst17, t.Mst18, t.Mst19, t.Mst20, t.Personnum });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Activeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Input1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input2)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Input3)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input4)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input5)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input6)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input7)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input8)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input9)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input10)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input11)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input12)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input13)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input14)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input15)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input16)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input17)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input18)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input19)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input20)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mst1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mst2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mst3)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mst4)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mst5)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mst6)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mst7)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mst8)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mst9)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mst10)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mst11)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mst12)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mst13)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mst14)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mst15)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mst16)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mst17)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mst18)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mst19)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mst20)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Personnum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_Act_Reginput");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Activeid).HasColumnName("Activeid");
            this.Property(t => t.Input1).HasColumnName("Input1");
            this.Property(t => t.Input2).HasColumnName("Input2");
            this.Property(t => t.Input3).HasColumnName("Input3");
            this.Property(t => t.Input4).HasColumnName("Input4");
            this.Property(t => t.Input5).HasColumnName("Input5");
            this.Property(t => t.Input6).HasColumnName("Input6");
            this.Property(t => t.Input7).HasColumnName("Input7");
            this.Property(t => t.Input8).HasColumnName("Input8");
            this.Property(t => t.Input9).HasColumnName("Input9");
            this.Property(t => t.Input10).HasColumnName("Input10");
            this.Property(t => t.Input11).HasColumnName("Input11");
            this.Property(t => t.Input12).HasColumnName("Input12");
            this.Property(t => t.Input13).HasColumnName("Input13");
            this.Property(t => t.Input14).HasColumnName("Input14");
            this.Property(t => t.Input15).HasColumnName("Input15");
            this.Property(t => t.Input16).HasColumnName("Input16");
            this.Property(t => t.Input17).HasColumnName("Input17");
            this.Property(t => t.Input18).HasColumnName("Input18");
            this.Property(t => t.Input19).HasColumnName("Input19");
            this.Property(t => t.Input20).HasColumnName("Input20");
            this.Property(t => t.Mst1).HasColumnName("Mst1");
            this.Property(t => t.Mst2).HasColumnName("Mst2");
            this.Property(t => t.Mst3).HasColumnName("Mst3");
            this.Property(t => t.Mst4).HasColumnName("Mst4");
            this.Property(t => t.Mst5).HasColumnName("Mst5");
            this.Property(t => t.Mst6).HasColumnName("Mst6");
            this.Property(t => t.Mst7).HasColumnName("Mst7");
            this.Property(t => t.Mst8).HasColumnName("Mst8");
            this.Property(t => t.Mst9).HasColumnName("Mst9");
            this.Property(t => t.Mst10).HasColumnName("Mst10");
            this.Property(t => t.Mst11).HasColumnName("Mst11");
            this.Property(t => t.Mst12).HasColumnName("Mst12");
            this.Property(t => t.Mst13).HasColumnName("Mst13");
            this.Property(t => t.Mst14).HasColumnName("Mst14");
            this.Property(t => t.Mst15).HasColumnName("Mst15");
            this.Property(t => t.Mst16).HasColumnName("Mst16");
            this.Property(t => t.Mst17).HasColumnName("Mst17");
            this.Property(t => t.Mst18).HasColumnName("Mst18");
            this.Property(t => t.Mst19).HasColumnName("Mst19");
            this.Property(t => t.Mst20).HasColumnName("Mst20");
            this.Property(t => t.Personnum).HasColumnName("Personnum");
        }
    }
}
