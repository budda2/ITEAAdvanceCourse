using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disposable
{
    internal class ResourceUser
    {
        public void Do()
        {
            var resource = new UnmanagedResourceHandler();
            var anotherResource = new UnmanagedResourceHandler();

            using (resource)
            using (anotherResource)
                resource.Start();

            //using is compiled to the following
            try
            {
                resource.Start();
            }
            finally
            {
                resource.Dispose();
            }
        }
    }
}
