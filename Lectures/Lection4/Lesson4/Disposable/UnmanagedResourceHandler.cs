using System;
using System.Threading;

namespace Disposable
{
    public class UnmanagedResourceHandler : IDisposable
    {
        private Timer _timer;
        public UnmanagedResourceHandler()
        {
            _timer = new Timer(o => DoOnTick(o), null, 100, 100);
        }

        public void Start()
        {
            if (disposedValue == true)
                throw new ObjectDisposedException("UnmanagedResourceHandler");
        }

        private void DoOnTick(object obj)
        {
            System.Console.WriteLine("Tick.");
            System.Console.ReadLine();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _timer.Dispose();
                    _timer = null;
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

         ~UnmanagedResourceHandler()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
