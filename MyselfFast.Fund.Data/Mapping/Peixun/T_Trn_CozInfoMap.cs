//
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using myselfFast.Fund.Core.Domain.Peixun;

namespace myselfFast.Fund.Data.Mapping.Peixun
{
    public class T_Trn_CozInfoMap : myselfFastEntityTypeConfiguration<T_Trn_CozInfo>
    {
        public T_Trn_CozInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.VideoId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ThumbnailSrc)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.TrnFileSrc)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.TrnContent)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.LabelIds)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Trn_CozInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.IsOpen).HasColumnName("IsOpen");
            this.Property(t => t.BeginTime).HasColumnName("BeginTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.Credit).HasColumnName("Credit");
            this.Property(t => t.OpenDegree).HasColumnName("OpenDegree");
            this.Property(t => t.VideoId).HasColumnName("VideoId");
            this.Property(t => t.ThumbnailSrc).HasColumnName("ThumbnailSrc");
            this.Property(t => t.TrnFileSrc).HasColumnName("TrnFileSrc");
            this.Property(t => t.IsText).HasColumnName("IsText");
            this.Property(t => t.SumMin).HasColumnName("SumMin");
            this.Property(t => t.TrnContent).HasColumnName("TrnContent");
            this.Property(t => t.LabelIds).HasColumnName("LabelIds");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateUserId).HasColumnName("CreateUserId");
            this.Property(t => t.CreatTime).HasColumnName("CreatTime");
            this.Property(t => t.EditUserId).HasColumnName("EditUserId");
            this.Property(t => t.EditTime).HasColumnName("EditTime");
        }
    }
}
