using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_GysMap : EntityTypeConfiguration<T_Gds_Gys>
    {
        public T_Gds_GysMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Gname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Gcode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Gaddress)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Gpost)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Gcontact)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Gtel)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Gphone)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Gfax)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Gemail)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Gheadway)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Gbuslic)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Gbuslic_Ser)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Ginstcode)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Ginstcode_Ser)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Gcontract)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Gcontract_Ser)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Gplacelist_Ser)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Gother_Ser)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Gsource)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Logip)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.JianCheng)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Ename)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("T_Gds_Gys");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Gname).HasColumnName("Gname");
            this.Property(t => t.Gcode).HasColumnName("Gcode");
            this.Property(t => t.Gaddress).HasColumnName("Gaddress");
            this.Property(t => t.Gpost).HasColumnName("Gpost");
            this.Property(t => t.Gcontact).HasColumnName("Gcontact");
            this.Property(t => t.Gtel).HasColumnName("Gtel");
            this.Property(t => t.Gphone).HasColumnName("Gphone");
            this.Property(t => t.Gfax).HasColumnName("Gfax");
            this.Property(t => t.Gemail).HasColumnName("Gemail");
            this.Property(t => t.Gheadway).HasColumnName("Gheadway");
            this.Property(t => t.Gcycle).HasColumnName("Gcycle");
            this.Property(t => t.Gcycledate).HasColumnName("Gcycledate");
            this.Property(t => t.Gcondate).HasColumnName("Gcondate");
            this.Property(t => t.Gcondateend).HasColumnName("Gcondateend");
            this.Property(t => t.Gremindday).HasColumnName("Gremindday");
            this.Property(t => t.Gbuslic).HasColumnName("Gbuslic");
            this.Property(t => t.Gbuslic_Ser).HasColumnName("Gbuslic_Ser");
            this.Property(t => t.Ginstcode).HasColumnName("Ginstcode");
            this.Property(t => t.Ginstcode_Ser).HasColumnName("Ginstcode_Ser");
            this.Property(t => t.Gcontract).HasColumnName("Gcontract");
            this.Property(t => t.Gcontract_Ser).HasColumnName("Gcontract_Ser");
            this.Property(t => t.Gplacelist_Ser).HasColumnName("Gplacelist_Ser");
            this.Property(t => t.Gother_Ser).HasColumnName("Gother_Ser");
            this.Property(t => t.Gsource).HasColumnName("Gsource");
            this.Property(t => t.Logtime).HasColumnName("Logtime");
            this.Property(t => t.Logip).HasColumnName("Logip");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
            this.Property(t => t.JianCheng).HasColumnName("JianCheng");
            this.Property(t => t.Ename).HasColumnName("Ename");
            this.Property(t => t.Mid).HasColumnName("Mid");
        }
    }
}
