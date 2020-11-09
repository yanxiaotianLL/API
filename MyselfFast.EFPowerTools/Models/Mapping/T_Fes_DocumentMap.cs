using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_DocumentMap : EntityTypeConfiguration<T_Fes_Document>
    {
        public T_Fes_DocumentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.AttType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Filename)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Filetype)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Filedescript)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CreaterName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EditerName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Fes_Document");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AttType).HasColumnName("AttType");
            this.Property(t => t.Attid).HasColumnName("Attid");
            this.Property(t => t.Filename).HasColumnName("Filename");
            this.Property(t => t.Filesize).HasColumnName("Filesize");
            this.Property(t => t.Filetype).HasColumnName("Filetype");
            this.Property(t => t.Filedescript).HasColumnName("Filedescript");
            this.Property(t => t.CreaterId).HasColumnName("CreaterId");
            this.Property(t => t.CreaterName).HasColumnName("CreaterName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.EditerId).HasColumnName("EditerId");
            this.Property(t => t.EditerName).HasColumnName("EditerName");
            this.Property(t => t.EditTime).HasColumnName("EditTime");
        }
    }
}
