using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Examples
{
    internal class LockExample
    {
        private object _lockObject = new object();

        public void Do()
        {
            lock(_lockObject)
            {
                Thread.Sleep(50);
            }
        }

        public void DoSomething()
        {
            lock(_lockObject)
            {
                Thread.Sleep(50);
            }
        }
    }
}
