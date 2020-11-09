﻿

using myselfFast.Fund.Core;
using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Core.Infrastructure;
using System.Data.Entity;
namespace myselfFast.Fund.Data 
{
    public class EfStartUpTask : IStartupTask
    {
        public void Execute()
        {
            var settings = EngineContext.Current.Resolve<DataSettings>();
            if (settings != null && settings.IsValid())
            {
                var provider = EngineContext.Current.Resolve<IDataProvider>();
                if (provider == null)
                    throw new myselfFastException("No IDataProvider found");
                provider.SetDatabaseInitializer();
                
            }
        }

        public int Order
        {
            //ensure that this task is run first 
            get { return 0; }
        }
    }
}
