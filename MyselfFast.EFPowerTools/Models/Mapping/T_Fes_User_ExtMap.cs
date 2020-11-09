using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_User_ExtMap : EntityTypeConfiguration<T_Fes_User_Ext>
    {
        public T_Fes_User_ExtMap()
        {
            // Primary Key
            this.HasKey(t => t.Fesid);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Fesid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Native)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Addrdetail)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Location)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Province)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Xian)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Tel)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Yewubu)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.YewubuUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Msn)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Qq)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Lov)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Postcode)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.Depart)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Grade)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.busiCustNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.conNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MedicalPosition)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Img)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Temp_Jd)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserYewubu)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserYewubuUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.custName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.busiCustName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.conName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.acceName)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Fes_User_Ext");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Pborth).HasColumnName("Pborth");
            this.Property(t => t.Mborth).HasColumnName("Mborth");
            this.Property(t => t.Lborth).HasColumnName("Lborth");
            this.Property(t => t.Sborth).HasColumnName("Sborth");
            this.Property(t => t.Native).HasColumnName("Native");
            this.Property(t => t.Addrdetail).HasColumnName("Addrdetail");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.ProvinceId).HasColumnName("ProvinceId");
            this.Property(t => t.Province).HasColumnName("Province");
            this.Property(t => t.XianId).HasColumnName("XianId");
            this.Property(t => t.Xian).HasColumnName("Xian");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Yewubu).HasColumnName("Yewubu");
            this.Property(t => t.YewubuUser).HasColumnName("YewubuUser");
            this.Property(t => t.Msn).HasColumnName("Msn");
            this.Property(t => t.Qq).HasColumnName("Qq");
            this.Property(t => t.Lov).HasColumnName("Lov");
            this.Property(t => t.Postcode).HasColumnName("Postcode");
            this.Property(t => t.Depart).HasColumnName("Depart");
            this.Property(t => t.Grade).HasColumnName("Grade");
            this.Property(t => t.Workyears).HasColumnName("Workyears");
            this.Property(t => t.Hasboys).HasColumnName("Hasboys");
            this.Property(t => t.busiCustNo).HasColumnName("busiCustNo");
            this.Property(t => t.conNo).HasColumnName("conNo");
            this.Property(t => t.MedicalPosition).HasColumnName("MedicalPosition");
            this.Property(t => t.Img).HasColumnName("Img");
            this.Property(t => t.Temp_Jd).HasColumnName("Temp_Jd");
            this.Property(t => t.Verifydate).HasColumnName("Verifydate");
            this.Property(t => t.Serisbinding).HasColumnName("Serisbinding");
            this.Property(t => t.Serbindingdate).HasColumnName("Serbindingdate");
            this.Property(t => t.Orderid).HasColumnName("Orderid");
            this.Property(t => t.Sbimagesdate).HasColumnName("Sbimagesdate");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.RecordFlowId).HasColumnName("RecordFlowId");
            this.Property(t => t.ElecMatSource).HasColumnName("ElecMatSource");
            this.Property(t => t.Iddate).HasColumnName("Iddate");
            this.Property(t => t.CradRecordFlowId).HasColumnName("CradRecordFlowId");
            this.Property(t => t.UserYewubu).HasColumnName("UserYewubu");
            this.Property(t => t.UserYewubuUser).HasColumnName("UserYewubuUser");
            this.Property(t => t.custId).HasColumnName("custId");
            this.Property(t => t.custName).HasColumnName("custName");
            this.Property(t => t.busiCustId).HasColumnName("busiCustId");
            this.Property(t => t.busiCustName).HasColumnName("busiCustName");
            this.Property(t => t.conId).HasColumnName("conId");
            this.Property(t => t.conName).HasColumnName("conName");
            this.Property(t => t.acceId).HasColumnName("acceId");
            this.Property(t => t.acceName).HasColumnName("acceName");
        }
    }
}
