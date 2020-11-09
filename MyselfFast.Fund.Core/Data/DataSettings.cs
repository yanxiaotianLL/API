using System;
using System.Collections.Generic;

namespace myselfFast.Fund.Core.Data
{
    /// <summary>
    /// Data settings (connection string information)
    /// </summary>
    // TODO:ef配置文件待订制化
    public partial class DataSettings
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public DataSettings()
        {
            RawDataSettings=new Dictionary<string, string>();
        }

        /// <summary>
        /// Data provider
        /// </summary>
        public string DataProvider { get; set; }

        /// <summary>
        /// Connection string
        /// </summary>
        public string DataConnectionString { get; set; }

        /// <summary>
        /// Raw settings file
        /// </summary>
        public IDictionary<string, string> RawDataSettings { get; private set; }

        /// <summary>
        /// A value indicating whether entered information is valid
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            return !String.IsNullOrEmpty(this.DataProvider) && !String.IsNullOrEmpty(this.DataConnectionString);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetCommonConnectionString()
        {
            // Data Source=192.168.0.79;Initial Catalog=FesSysBak2;Integrated Security=False;Persist Security Info=False;User ID=FesSys;Password=!qazxsw2
           
            Dictionary<string, string> dic = new Dictionary<string, string>();
            var strs = this.DataConnectionString.Split(';');
            foreach (var item in strs)
            {
                var ss = item.Split('=');
                dic.Add(ss[0], ss[1]);

            }
            string connection = string.Format("data source={0};uid={1};pwd={2};database={3};Connect Timeout=21600;", dic["Data Source"], dic["User ID"], dic["Password"], dic["Initial Catalog"]);

            return connection;
        }
    }
}
