using System;

namespace UnitOfWorkADONET
{
    public interface IUnityOfWork : IDisposable
    {
        void SaveChanges();
        void CancelChanges();

    }
}
