using System;
using System.Collections.Generic;

namespace FescoFast.Collect.Core.Test.Models
{
    public partial class T_JC_DataItem
    {
        public long Id { get; set; }
        public string order_id { get; set; }
        public string UNIQ_NO { get; set; }
        public string EMP_NAME { get; set; }
        public string CER_TYPE { get; set; }
        public string EMP_ID_CARD { get; set; }
        public string EMP_IN_CODE { get; set; }
        public string COST_CENT_NO { get; set; }
        public string PER_PKG_NAME { get; set; }
        public string REG_NO { get; set; }
        public string UNIT_REG_NO { get; set; }
        public string UNIT_NO { get; set; }
        public string UNIT_NAME_PRINT { get; set; }
        public string INS_DECL_WAGE { get; set; }
        public string INS_BASE_WAGE { get; set; }
        public string ACCU_DECL_WAGE { get; set; }
        public string ACCU_BASE_WAGE { get; set; }
        public string BUSI_CUST_NO { get; set; }
        public string BUSI_CUST_NAME { get; set; }
        public string CONT_NO { get; set; }
        public string CONT_NAME { get; set; }
        public string ACCE_NO { get; set; }
        public string ACCE_NAME { get; set; }
        public string RECE_ORG_NAME { get; set; }
        public string RECE_USER { get; set; }
        public string RECE_LOGIN_NAME { get; set; }
        public string SEND_ORG_NAME { get; set; }
        public string SEND_USER { get; set; }
        public string SEND_LOGIN_NAME { get; set; }
        public string SEND_LOGIN_EMAIL { get; set; }
        public string SUPP_NAME { get; set; }
        public string SUPP_NO { get; set; }
        public string AREA_ID { get; set; }
        public string COLLT_TYPE { get; set; }
        public string PER_PKG_ID { get; set; }
        public string BUSI_CUST_ID { get; set; }
        public string CUST_CON_ID { get; set; }
        public string CON_ACCE_ID { get; set; }
        public string RECE_ORG_ID { get; set; }
        public string RECE_USER_ID { get; set; }
        public string SEND_ORG_ID { get; set; }
        public string SEND_USER_ID { get; set; }
        public Nullable<int> JC_Task_ID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public string RECE_SUPPLIERR_NAME { get; set; }
        public string APEA { get; set; }
        public string PRODUCTTYPE { get; set; }
        public string PRODUCTID { get; set; }
        public string RECE_SUPPLIER_ID { get; set; }
        public string SEND_SUPPLIER_ID { get; set; }
        public virtual T_JC_Task T_JC_Task { get; set; }
    }
}
