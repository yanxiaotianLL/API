using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_ProjectMap : EntityTypeConfiguration<T_Exm_Project>
    {
        public T_Exm_ProjectMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FlsName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.EName)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Pid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ContractNum)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.OurPerson)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PeerPerson)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PackageIds)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Packages)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.Context)
                .IsRequired();

            this.Property(t => t.CardRule)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.AllotStart)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.AllotEnd)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CreaterName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EditerName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ProjectNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Pic)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OtherVerify)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CustTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.mnkey)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.mnpassword)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_Exm_Project");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.FlsName).HasColumnName("FlsName");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.EName).HasColumnName("EName");
            this.Property(t => t.Pid).HasColumnName("Pid");
            this.Property(t => t.IsChooseCity).HasColumnName("IsChooseCity");
            this.Property(t => t.IsAction).HasColumnName("IsAction");
            this.Property(t => t.ContractNum).HasColumnName("ContractNum");
            this.Property(t => t.OurPerson).HasColumnName("OurPerson");
            this.Property(t => t.PeerPerson).HasColumnName("PeerPerson");
            this.Property(t => t.ContracDate).HasColumnName("ContracDate");
            this.Property(t => t.PackageIds).HasColumnName("PackageIds");
            this.Property(t => t.Packages).HasColumnName("Packages");
            this.Property(t => t.Context).HasColumnName("Context");
            this.Property(t => t.Cost).HasColumnName("Cost");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.PType).HasColumnName("PType");
            this.Property(t => t.CardRule).HasColumnName("CardRule");
            this.Property(t => t.StartPos).HasColumnName("StartPos");
            this.Property(t => t.EndPos).HasColumnName("EndPos");
            this.Property(t => t.AllotStart).HasColumnName("AllotStart");
            this.Property(t => t.AllotEnd).HasColumnName("AllotEnd");
            this.Property(t => t.LStart).HasColumnName("LStart");
            this.Property(t => t.LEnd).HasColumnName("LEnd");
            this.Property(t => t.LDays).HasColumnName("LDays");
            this.Property(t => t.CreaterId).HasColumnName("CreaterId");
            this.Property(t => t.CreaterName).HasColumnName("CreaterName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.EditerId).HasColumnName("EditerId");
            this.Property(t => t.EditerName).HasColumnName("EditerName");
            this.Property(t => t.EditTime).HasColumnName("EditTime");
            this.Property(t => t.IsFamily).HasColumnName("IsFamily");
            this.Property(t => t.ProjectNo).HasColumnName("ProjectNo");
            this.Property(t => t.Packagetype).HasColumnName("Packagetype");
            this.Property(t => t.CheckType).HasColumnName("CheckType");
            this.Property(t => t.Pic).HasColumnName("Pic");
            this.Property(t => t.IsIntervention).HasColumnName("IsIntervention");
            this.Property(t => t.OtherVerify).HasColumnName("OtherVerify");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CustTypeName).HasColumnName("CustTypeName");
            this.Property(t => t.mnkey).HasColumnName("mnkey");
            this.Property(t => t.mnpassword).HasColumnName("mnpassword");
            this.Property(t => t.PackageEndTime).HasColumnName("PackageEndTime");
            this.Property(t => t.PayEndTime).HasColumnName("PayEndTime");
            this.Property(t => t.PriceMarket).HasColumnName("PriceMarket");
            this.Property(t => t.PricePromoCode).HasColumnName("PricePromoCode");
            this.Property(t => t.PriceRakeBack).HasColumnName("PriceRakeBack");
        }
    }
}
