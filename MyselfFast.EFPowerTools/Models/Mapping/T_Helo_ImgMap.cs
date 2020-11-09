using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using FescoFast.Fund.Core.Domain.Banner;

namespace FescoFast.Fund.Data.Mapping.Banner
{
    public class T_Helo_ImgMap : FescoFastEntityTypeConfiguration<T_Helo_Img>
    {
        public T_Helo_ImgMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ImgUrl)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ImgTitle)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ToUrl)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ImgBackColor)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CreateUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UpdateUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Helo_Img");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ImgUrl).HasColumnName("ImgUrl");
            this.Property(t => t.ImgTitle).HasColumnName("ImgTitle");
            this.Property(t => t.ImgState).HasColumnName("ImgState");
            this.Property(t => t.ToUrl).HasColumnName("ToUrl");
            this.Property(t => t.ImgIndex).HasColumnName("ImgIndex");
            this.Property(t => t.ImgPlace).HasColumnName("ImgPlace");
            this.Property(t => t.ImgBackColor).HasColumnName("ImgBackColor");
            this.Property(t => t.BeginTime).HasColumnName("BeginTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.UpdateUser).HasColumnName("UpdateUser");
        }
    }
}

