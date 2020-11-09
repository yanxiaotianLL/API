using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Configuration
{
    public class FundextRentConfiguration
    {
        /// <summary>
        /// 在线支取金额基准
        /// </summary>
        public string ZxzqAmount { get; set; }
        /// <summary>
        /// 是否开启手机实名验证
        /// </summary>
        public string MobileVerify { get; set; }
        public string PrveUrl { get; set; }
        public string FrontUrl { get; set; }  
    }
}
