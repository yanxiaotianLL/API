using myselfFast.Fund.Core;
using myselfFast.Fund.Core.Data;
using System;


namespace myselfFast.Fund.Data 
{
    public partial class EfDataProviderManager : BaseDataProviderManager
    {
        public EfDataProviderManager(DataSettings settings):base(settings)
        {
        }

        public override IDataProvider LoadDataProvider()
        {

            var providerName = Settings.DataProvider;
            if (String.IsNullOrWhiteSpace(providerName))
                throw new myselfFastException("Data Settings doesn't contain a providerName");

            switch (providerName.ToLowerInvariant())
            {
                case "sqlserver":
                    return new SqlServerDataProvider();
                case "sqlce":
                    return new SqlCeDataProvider();
                default:
                    throw new myselfFastException(string.Format("Not supported dataprovider name: {0}", providerName));
            }
        }

    }
}
