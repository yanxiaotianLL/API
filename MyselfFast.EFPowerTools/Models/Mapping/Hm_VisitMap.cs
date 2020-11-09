using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hm_VisitMap : EntityTypeConfiguration<Hm_Visit>
    {
        public Hm_VisitMap()
        {
            // Primary Key
            this.HasKey(t => t.Months);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Months)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Hm_Visit");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Months).HasColumnName("Months");
            this.Property(t => t.Zhuceyonghus).HasColumnName("Zhuceyonghus");
            this.Property(t => t.Renzhengyuangongs).HasColumnName("Renzhengyuangongs");
            this.Property(t => t.Zaizhiyuangongs).HasColumnName("Zaizhiyuangongs");
            this.Property(t => t.Ruzhiyuyue).HasColumnName("Ruzhiyuyue");
            this.Property(t => t.Lizhiyuyue).HasColumnName("Lizhiyuyue");
            this.Property(t => t.Hdudongs).HasColumnName("Hdudongs");
            this.Property(t => t.Yuangongs).HasColumnName("Yuangongs");
            this.Property(t => t.Baomings).HasColumnName("Baomings");
            this.Property(t => t.Tiwens).HasColumnName("Tiwens");
            this.Property(t => t.Huifus).HasColumnName("Huifus");
            this.Property(t => t.Zhutis).HasColumnName("Zhutis");
            this.Property(t => t.Faties).HasColumnName("Faties");
            this.Property(t => t.Shebaos).HasColumnName("Shebaos");
            this.Property(t => t.Jiaguwenzhuce).HasColumnName("Jiaguwenzhuce");
            this.Property(t => t.Zaixianyewu).HasColumnName("Zaixianyewu");
            this.Property(t => t.Zaixianzongliang).HasColumnName("Zaixianzongliang");
            this.Property(t => t.Ruzhiyuyuetijiao).HasColumnName("Ruzhiyuyuetijiao");
            this.Property(t => t.Ruzhiyuyuewancheng).HasColumnName("Ruzhiyuyuewancheng");
            this.Property(t => t.Lizhiyuyuetijiao).HasColumnName("Lizhiyuyuetijiao");
            this.Property(t => t.Lizhiyuyuewancheng).HasColumnName("Lizhiyuyuewancheng");
            this.Property(t => t.Jitihukoutijiao).HasColumnName("Jitihukoutijiao");
            this.Property(t => t.Jitihukouwancheng).HasColumnName("Jitihukouwancheng");
            this.Property(t => t.Gongjijingtijiao).HasColumnName("Gongjijingtijiao");
            this.Property(t => t.Gongjijingwancheng).HasColumnName("Gongjijingwancheng");
            this.Property(t => t.Tijianzhonglei).HasColumnName("Tijianzhonglei");
            this.Property(t => t.Tijiankaika).HasColumnName("Tijiankaika");
            this.Property(t => t.Dztijianxm).HasColumnName("Dztijianxm");
            this.Property(t => t.Dztijianfw).HasColumnName("Dztijianfw");
            this.Property(t => t.Tijianyuyue).HasColumnName("Tijianyuyue");
            this.Property(t => t.Tijiangoumaishu).HasColumnName("Tijiangoumaishu");
            this.Property(t => t.Tijiangoumaijine).HasColumnName("Tijiangoumaijine");
            this.Property(t => t.Licaiyudingjine).HasColumnName("Licaiyudingjine");
            this.Property(t => t.Licaiyudingrenci).HasColumnName("Licaiyudingrenci");
            this.Property(t => t.Licaiyudingrenshu).HasColumnName("Licaiyudingrenshu");
            this.Property(t => t.Licaisxshuliang).HasColumnName("Licaisxshuliang");
        }
    }
}
