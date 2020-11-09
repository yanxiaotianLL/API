using System.Data.Entity.ModelConfiguration;

namespace myselfFast.Fund.Data.Mapping
{
    public abstract class myselfFastEntityTypeConfiguration<T> : EntityTypeConfiguration<T> where T : class
    {
        protected myselfFastEntityTypeConfiguration()
        {
            PostInitialize();
        }

        /// <summary>
        /// Developers can override this method in custom partial classes
        /// in order to add some custom initialization code to constructors
        /// </summary>
        protected virtual void PostInitialize()
        {
            
        }
    }
}