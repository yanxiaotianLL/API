using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sys_FileMap : EntityTypeConfiguration<T_Sys_File>
    {
        public T_Sys_FileMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TableName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FilePath)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.FileType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FileName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FileFormat)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CardId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PhoneSysterm)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.MergePicId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RevisePicId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FileId)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Sys_File");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.TableName).HasColumnName("TableName");
            this.Property(t => t.FilePath).HasColumnName("FilePath");
            this.Property(t => t.FileType).HasColumnName("FileType");
            this.Property(t => t.FileSize).HasColumnName("FileSize");
            this.Property(t => t.UpLoadDate).HasColumnName("UpLoadDate");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.IsValue).HasColumnName("IsValue");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.FileFormat).HasColumnName("FileFormat");
            this.Property(t => t.FormalityId).HasColumnName("FormalityId");
            this.Property(t => t.ElecMatSource).HasColumnName("ElecMatSource");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.FileNo).HasColumnName("FileNo");
            this.Property(t => t.RecordFlowId).HasColumnName("RecordFlowId");
            this.Property(t => t.CardId).HasColumnName("CardId");
            this.Property(t => t.PhoneSysterm).HasColumnName("PhoneSysterm");
            this.Property(t => t.MergePicId).HasColumnName("MergePicId");
            this.Property(t => t.RevisePicId).HasColumnName("RevisePicId");
            this.Property(t => t.FileId).HasColumnName("FileId");
        }
    }
}
