using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_Dan_ExtMap : EntityTypeConfiguration<T_Gds_Dan_Ext>
    {
        public T_Gds_Dan_ExtMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Idcard)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Bianhao)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Childname)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Childsex)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Childold)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Childidcard)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Childheal)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Spousename)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Spousesex)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spouseold)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spouseidcard)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Spouseheal)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Parentname)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Parentsex)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Parentold)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Parentidcard)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Parentheal)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.childcardtype)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.childnationality)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.childlivecity)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.childemail)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.childphone)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.childbank)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.childbankaccount)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spousecardtype)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spousenationality)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spouselivecity)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spouseemail)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spousephone)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spousebank)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spousebankaccount)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Parentcardtype)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Parentnationality)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Parentlivecity)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Parentemail)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Parentphone)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Parentbank)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Parentbankaccount)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.wordfile)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.pdffile)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.cardfile)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Childname1)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Childsex1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.childcardtype1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Childnationality1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Childlivecity1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Childidcard1)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("T_Gds_Dan_Ext");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Idcard).HasColumnName("Idcard");
            this.Property(t => t.Bianhao).HasColumnName("Bianhao");
            this.Property(t => t.Childname).HasColumnName("Childname");
            this.Property(t => t.Childbirth).HasColumnName("Childbirth");
            this.Property(t => t.Childsex).HasColumnName("Childsex");
            this.Property(t => t.Childold).HasColumnName("Childold");
            this.Property(t => t.Childidcard).HasColumnName("Childidcard");
            this.Property(t => t.Childheal).HasColumnName("Childheal");
            this.Property(t => t.Spousename).HasColumnName("Spousename");
            this.Property(t => t.Spousebirth).HasColumnName("Spousebirth");
            this.Property(t => t.Spousesex).HasColumnName("Spousesex");
            this.Property(t => t.Spouseold).HasColumnName("Spouseold");
            this.Property(t => t.Spouseidcard).HasColumnName("Spouseidcard");
            this.Property(t => t.Spouseheal).HasColumnName("Spouseheal");
            this.Property(t => t.Parentname).HasColumnName("Parentname");
            this.Property(t => t.Parentbrith).HasColumnName("Parentbrith");
            this.Property(t => t.Parentsex).HasColumnName("Parentsex");
            this.Property(t => t.Parentold).HasColumnName("Parentold");
            this.Property(t => t.Parentidcard).HasColumnName("Parentidcard");
            this.Property(t => t.Parentheal).HasColumnName("Parentheal");
            this.Property(t => t.childcardtype).HasColumnName("childcardtype");
            this.Property(t => t.childnationality).HasColumnName("childnationality");
            this.Property(t => t.childlivecity).HasColumnName("childlivecity");
            this.Property(t => t.childemail).HasColumnName("childemail");
            this.Property(t => t.childphone).HasColumnName("childphone");
            this.Property(t => t.childbank).HasColumnName("childbank");
            this.Property(t => t.childbankaccount).HasColumnName("childbankaccount");
            this.Property(t => t.Spousecardtype).HasColumnName("Spousecardtype");
            this.Property(t => t.Spousenationality).HasColumnName("Spousenationality");
            this.Property(t => t.Spouselivecity).HasColumnName("Spouselivecity");
            this.Property(t => t.Spouseemail).HasColumnName("Spouseemail");
            this.Property(t => t.Spousephone).HasColumnName("Spousephone");
            this.Property(t => t.Spousebank).HasColumnName("Spousebank");
            this.Property(t => t.Spousebankaccount).HasColumnName("Spousebankaccount");
            this.Property(t => t.Parentcardtype).HasColumnName("Parentcardtype");
            this.Property(t => t.Parentnationality).HasColumnName("Parentnationality");
            this.Property(t => t.Parentlivecity).HasColumnName("Parentlivecity");
            this.Property(t => t.Parentemail).HasColumnName("Parentemail");
            this.Property(t => t.Parentphone).HasColumnName("Parentphone");
            this.Property(t => t.Parentbank).HasColumnName("Parentbank");
            this.Property(t => t.Parentbankaccount).HasColumnName("Parentbankaccount");
            this.Property(t => t.wordfile).HasColumnName("wordfile");
            this.Property(t => t.pdffile).HasColumnName("pdffile");
            this.Property(t => t.cardfile).HasColumnName("cardfile");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Tid).HasColumnName("Tid");
            this.Property(t => t.Orderid).HasColumnName("Orderid");
            this.Property(t => t.Childname1).HasColumnName("Childname1");
            this.Property(t => t.Childbirth1).HasColumnName("Childbirth1");
            this.Property(t => t.Childsex1).HasColumnName("Childsex1");
            this.Property(t => t.childcardtype1).HasColumnName("childcardtype1");
            this.Property(t => t.Childnationality1).HasColumnName("Childnationality1");
            this.Property(t => t.Childlivecity1).HasColumnName("Childlivecity1");
            this.Property(t => t.Childidcard1).HasColumnName("Childidcard1");
        }
    }
}
