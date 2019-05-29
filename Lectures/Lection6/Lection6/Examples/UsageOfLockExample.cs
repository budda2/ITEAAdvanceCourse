using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public class UsageOfLockExample
    {
        public async Task UseLockExample()
        {
            var lockExample = new LockExample();

            var doTask = Task.Run(() => lockExample.Do());
            var doTask1 = Task.Run(() => lockExample.DoSomething());

            await Task.WhenAll(doTask, doTask1);
        }
    }
}
