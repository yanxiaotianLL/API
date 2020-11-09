using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Configuration
{
   public class PhoneConfiguration
    {
       /// <summary>
        /// 二维码扫描后跳转地址
       /// </summary>
       public string FileServerUrl { get; set; }
       /// <summary>
       /// 公钥
       /// </summary>
       public string Secret { get; set; }
       /// <summary>
       /// 二维码保存路径
       /// </summary>
       public string QrCodePath { get; set; }
       /// <summary>
       /// HELO端地址（Esvr）
       /// </summary>
     //  public string HeloEsvrUrl { get; set; }
       /// <summary>
       /// Helo端地址（FS.HELO.UI）
       /// </summary>
       public string HeloEsvrUrlNew { get; set; }
     
    }
}
