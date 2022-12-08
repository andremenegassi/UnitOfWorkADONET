using System;
using System.Data.Common;

namespace UnitOfWorkADONET
{
    public interface IDBContextFactory
    {
        public enum TpProvider
        {
            MySQL = 1,
            SQLServer = 2
        }
      
        DbConnection Create();
    }
}
