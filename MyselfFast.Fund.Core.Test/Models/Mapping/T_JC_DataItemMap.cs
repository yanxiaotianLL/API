using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.Collect.Core.Test.Models.Mapping
{
    public class T_JC_DataItemMap : EntityTypeConfiguration<T_JC_DataItem>
    {
        public T_JC_DataItemMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.order_id)
                .HasMaxLength(50);

            this.Property(t => t.UNIQ_NO)
                .HasMaxLength(20);

            this.Property(t => t.EMP_NAME)
                .HasMaxLength(200);

            this.Property(t => t.CER_TYPE)
                .HasMaxLength(20);

            this.Property(t => t.EMP_ID_CARD)
                .HasMaxLength(20);

            this.Property(t => t.EMP_IN_CODE)
                .HasMaxLength(50);

            this.Property(t => t.COST_CENT_NO)
                .HasMaxLength(50);

            this.Property(t => t.PER_PKG_NAME)
                .HasMaxLength(200);

            this.Property(t => t.REG_NO)
                .HasMaxLength(30);

            this.Property(t => t.UNIT_REG_NO)
                .HasMaxLength(30);

            this.Property(t => t.UNIT_NO)
                .HasMaxLength(30);

            this.Property(t => t.UNIT_NAME_PRINT)
                .HasMaxLength(50);

            this.Property(t => t.INS_DECL_WAGE)
                .HasMaxLength(30);

            this.Property(t => t.INS_BASE_WAGE)
                .HasMaxLength(30);

            this.Property(t => t.ACCU_DECL_WAGE)
                .HasMaxLength(30);

            this.Property(t => t.ACCU_BASE_WAGE)
                .HasMaxLength(30);

            this.Property(t => t.BUSI_CUST_NO)
                .HasMaxLength(30);

            this.Property(t => t.BUSI_CUST_NAME)
                .HasMaxLength(200);

            this.Property(t => t.CONT_NO)
                .HasMaxLength(30);

            this.Property(t => t.CONT_NAME)
                .HasMaxLength(200);

            this.Property(t => t.ACCE_NO)
                .HasMaxLength(30);

            this.Property(t => t.ACCE_NAME)
                .HasMaxLength(200);

            this.Property(t => t.RECE_ORG_NAME)
                .HasMaxLength(200);

            this.Property(t => t.RECE_USER)
                .HasMaxLength(50);

            this.Property(t => t.RECE_LOGIN_NAME)
                .HasMaxLength(30);

            this.Property(t => t.SEND_ORG_NAME)
                .HasMaxLength(200);

            this.Property(t => t.SEND_USER)
                .HasMaxLength(30);

            this.Property(t => t.SEND_LOGIN_NAME)
                .HasMaxLength(200);

            this.Property(t => t.SEND_LOGIN_EMAIL)
                .HasMaxLength(50);

            this.Property(t => t.SUPP_NAME)
                .HasMaxLength(200);

            this.Property(t => t.SUPP_NO)
                .HasMaxLength(30);

            this.Property(t => t.AREA_ID)
                .HasMaxLength(50);

            this.Property(t => t.COLLT_TYPE)
                .HasMaxLength(30);

            this.Property(t => t.PER_PKG_ID)
                .HasMaxLength(50);

            this.Property(t => t.BUSI_CUST_ID)
                .HasMaxLength(50);

            this.Property(t => t.CUST_CON_ID)
                .HasMaxLength(50);

            this.Property(t => t.CON_ACCE_ID)
                .HasMaxLength(20);

            this.Property(t => t.RECE_ORG_ID)
                .HasMaxLength(20);

            this.Property(t => t.RECE_USER_ID)
                .HasMaxLength(20);

            this.Property(t => t.SEND_ORG_ID)
                .HasMaxLength(20);

            this.Property(t => t.SEND_USER_ID)
                .HasMaxLength(20);

            this.Property(t => t.RECE_SUPPLIERR_NAME)
                .HasMaxLength(200);

            this.Property(t => t.APEA)
                .HasMaxLength(200);

            this.Property(t => t.PRODUCTTYPE)
                .HasMaxLength(20);

            this.Property(t => t.PRODUCTID)
                .HasMaxLength(50);

            this.Property(t => t.RECE_SUPPLIER_ID)
                .HasMaxLength(50);

            this.Property(t => t.SEND_SUPPLIER_ID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_JC_DataItem");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.order_id).HasColumnName("order_id");
            this.Property(t => t.UNIQ_NO).HasColumnName("UNIQ_NO");
            this.Property(t => t.EMP_NAME).HasColumnName("EMP_NAME");
            this.Property(t => t.CER_TYPE).HasColumnName("CER_TYPE");
            this.Property(t => t.EMP_ID_CARD).HasColumnName("EMP_ID_CARD");
            this.Property(t => t.EMP_IN_CODE).HasColumnName("EMP_IN_CODE");
            this.Property(t => t.COST_CENT_NO).HasColumnName("COST_CENT_NO");
            this.Property(t => t.PER_PKG_NAME).HasColumnName("PER_PKG_NAME");
            this.Property(t => t.REG_NO).HasColumnName("REG_NO");
            this.Property(t => t.UNIT_REG_NO).HasColumnName("UNIT_REG_NO");
            this.Property(t => t.UNIT_NO).HasColumnName("UNIT_NO");
            this.Property(t => t.UNIT_NAME_PRINT).HasColumnName("UNIT_NAME_PRINT");
            this.Property(t => t.INS_DECL_WAGE).HasColumnName("INS_DECL_WAGE");
            this.Property(t => t.INS_BASE_WAGE).HasColumnName("INS_BASE_WAGE");
            this.Property(t => t.ACCU_DECL_WAGE).HasColumnName("ACCU_DECL_WAGE");
            this.Property(t => t.ACCU_BASE_WAGE).HasColumnName("ACCU_BASE_WAGE");
            this.Property(t => t.BUSI_CUST_NO).HasColumnName("BUSI_CUST_NO");
            this.Property(t => t.BUSI_CUST_NAME).HasColumnName("BUSI_CUST_NAME");
            this.Property(t => t.CONT_NO).HasColumnName("CONT_NO");
            this.Property(t => t.CONT_NAME).HasColumnName("CONT_NAME");
            this.Property(t => t.ACCE_NO).HasColumnName("ACCE_NO");
            this.Property(t => t.ACCE_NAME).HasColumnName("ACCE_NAME");
            this.Property(t => t.RECE_ORG_NAME).HasColumnName("RECE_ORG_NAME");
            this.Property(t => t.RECE_USER).HasColumnName("RECE_USER");
            this.Property(t => t.RECE_LOGIN_NAME).HasColumnName("RECE_LOGIN_NAME");
            this.Property(t => t.SEND_ORG_NAME).HasColumnName("SEND_ORG_NAME");
            this.Property(t => t.SEND_USER).HasColumnName("SEND_USER");
            this.Property(t => t.SEND_LOGIN_NAME).HasColumnName("SEND_LOGIN_NAME");
            this.Property(t => t.SEND_LOGIN_EMAIL).HasColumnName("SEND_LOGIN_EMAIL");
            this.Property(t => t.SUPP_NAME).HasColumnName("SUPP_NAME");
            this.Property(t => t.SUPP_NO).HasColumnName("SUPP_NO");
            this.Property(t => t.AREA_ID).HasColumnName("AREA_ID");
            this.Property(t => t.COLLT_TYPE).HasColumnName("COLLT_TYPE");
            this.Property(t => t.PER_PKG_ID).HasColumnName("PER_PKG_ID");
            this.Property(t => t.BUSI_CUST_ID).HasColumnName("BUSI_CUST_ID");
            this.Property(t => t.CUST_CON_ID).HasColumnName("CUST_CON_ID");
            this.Property(t => t.CON_ACCE_ID).HasColumnName("CON_ACCE_ID");
            this.Property(t => t.RECE_ORG_ID).HasColumnName("RECE_ORG_ID");
            this.Property(t => t.RECE_USER_ID).HasColumnName("RECE_USER_ID");
            this.Property(t => t.SEND_ORG_ID).HasColumnName("SEND_ORG_ID");
            this.Property(t => t.SEND_USER_ID).HasColumnName("SEND_USER_ID");
            this.Property(t => t.JC_Task_ID).HasColumnName("JC_Task_ID");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.RECE_SUPPLIERR_NAME).HasColumnName("RECE_SUPPLIERR_NAME");
            this.Property(t => t.APEA).HasColumnName("APEA");
            this.Property(t => t.PRODUCTTYPE).HasColumnName("PRODUCTTYPE");
            this.Property(t => t.PRODUCTID).HasColumnName("PRODUCTID");
            this.Property(t => t.RECE_SUPPLIER_ID).HasColumnName("RECE_SUPPLIER_ID");
            this.Property(t => t.SEND_SUPPLIER_ID).HasColumnName("SEND_SUPPLIER_ID");

            // Relationships
            this.HasOptional(t => t.T_JC_Task)
                .WithMany(t => t.T_JC_DataItem)
                .HasForeignKey(d => d.JC_Task_ID);

        }
    }
}
